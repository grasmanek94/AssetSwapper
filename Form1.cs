using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AssetSwapper
{
    public partial class AssetSwapper : Form
    {
        Dictionary<string, byte[]> ExtensionToFile;

        public AssetSwapper()
        {
            InitializeComponent();

            ExtensionToFile = new Dictionary<string, byte[]>();

            ExtensionToFile[".aa3"] = Properties.Resources.empty_aa3;
            ExtensionToFile[".ac3"] = Properties.Resources.empty_ac3;
            ExtensionToFile[".aif"] = Properties.Resources.empty_aif;
            ExtensionToFile[".avi"] = Properties.Resources.empty_avi;
            ExtensionToFile[".bik"] = Properties.Resources.empty_bik;
            ExtensionToFile[".bmp"] = Properties.Resources.empty_bmp;
            ExtensionToFile[".flac"] = Properties.Resources.empty_flac;
            ExtensionToFile[".gif"] = Properties.Resources.empty_gif;
            ExtensionToFile[".jpg"] = Properties.Resources.empty_jpg;
            ExtensionToFile[".mp3"] = Properties.Resources.empty_mp3;
            ExtensionToFile[".mp4"] = Properties.Resources.empty_mp4;
            ExtensionToFile[".mpg"] = Properties.Resources.empty_mpg;
            ExtensionToFile[".ogg"] = Properties.Resources.empty_ogg;
            ExtensionToFile[".pca"] = Properties.Resources.empty_pca;
            ExtensionToFile[".png"] = Properties.Resources.empty_png;
            ExtensionToFile[".tif"] = Properties.Resources.empty_tif;
            ExtensionToFile[".w64"] = Properties.Resources.empty_w64;
            ExtensionToFile[".wav"] = Properties.Resources.empty_wav;
            ExtensionToFile[".wma"] = Properties.Resources.empty_wma;
            ExtensionToFile[".wmv"] = Properties.Resources.empty_wmv;

        }

        private void rb_RestoreAssets_CheckedChanged(object sender, EventArgs e)
        {
            btn_PerformAction.Text = "Restore";
        }

        private void rb_SwapAssets_CheckedChanged(object sender, EventArgs e)
        {
            btn_PerformAction.Text = "Swap";
        }

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, long count);

        static bool ByteArrayCompare(byte[] b1, byte[] b2)
        {
            // Validate buffers are the same length.
            // This also ensures that the count does not exceed the length of either buffer.  
            return b1.Length == b2.Length && memcmp(b1, b2, b1.Length) == 0;
        }

        private class AssetSwapInfo
        {
            public string FileName { get; set; }
            public string Extension { get; set; }
            public byte[] EmptyFileBytes { get; set; }

            public AssetSwapInfo(string fileName, string extension, byte[] emptyFileBytes)
            {
                FileName = fileName;
                Extension = extension;
                EmptyFileBytes = emptyFileBytes;
            }
        };

        // Process all files in the directory passed in, recurse on any directories  
        // that are found, and process the files they contain. 
        private List<AssetSwapInfo> ProcessDirectory(string targetDirectory, List<string> extensions, string ignoreDirectory, bool copyempty)
        {
            List<AssetSwapInfo> matching_files = new List<AssetSwapInfo>();

            if (!Path.GetFullPath(targetDirectory).Equals(Path.GetFullPath(ignoreDirectory), StringComparison.CurrentCultureIgnoreCase))
            {
                // Process the list of files found in the directory. 
                string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                {
                    string fileExtension = Path.GetExtension(fileName).ToLower();
                    if (extensions.Contains(fileExtension))
                    {
                        FileInfo info = new FileInfo(fileName);
                        byte[] empty = ExtensionToFile[fileExtension];
                        if (copyempty || info.Length != empty.Length)
                        {
                            matching_files.Add(new AssetSwapInfo(fileName, fileExtension, empty));
                        }
                        else
                        {
                            try
                            {
                                byte[] buff = File.ReadAllBytes(fileName);
                                if (!ByteArrayCompare(buff, empty))
                                {
                                    matching_files.Add(new AssetSwapInfo(fileName, fileExtension, empty));
                                }
                            }
                            catch(Exception)
                            {

                            }
                        }
                    }
                }

                // Recurse into subdirectories of this directory. 
                string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
                foreach (string subdirectory in subdirectoryEntries)
                {
                    matching_files.AddRange(ProcessDirectory(subdirectory, extensions, ignoreDirectory, copyempty));
                }
            }

            return matching_files;
        }

        private void PerformSwap(List<string> extensions)
        {
            List<AssetSwapInfo> matching_files = ProcessDirectory(".\\", extensions, ".\\ASSETS_BACKUP", false);

            string localPath = ".\\";
            string backupPath = ".\\ASSETS_BACKUP\\";

            foreach (AssetSwapInfo asi in matching_files)
            {
                try
                {
                    string destinationFile = asi.FileName.Replace(localPath, backupPath);
                    string destinationDirectory = Path.GetDirectoryName(destinationFile);

                    Directory.CreateDirectory(destinationDirectory);

                    if (File.Exists(destinationFile))
                    {
                        File.Delete(destinationFile);
                    }

                    File.Move(asi.FileName, destinationFile);
                    File.WriteAllBytes(asi.FileName, asi.EmptyFileBytes);
                }
                catch(Exception)
                {

                }
            }
        }

        private void PerformRestore(List<string> extensions)
        {
            List<AssetSwapInfo> matching_files = ProcessDirectory(".\\ASSETS_BACKUP", extensions, ".\\", false);

            string localPath = ".\\";
            string backupPath = ".\\ASSETS_BACKUP\\";

            foreach (AssetSwapInfo asi in matching_files)
            {
                try
                {
                    string destinationFile = asi.FileName.Replace(backupPath, localPath);
                    string destinationDirectory = Path.GetDirectoryName(destinationFile);

                    Directory.CreateDirectory(destinationDirectory);

                    if (File.Exists(destinationFile))
                    {
                        File.Delete(destinationFile);
                    }

                    File.Copy(asi.FileName, destinationFile);
                }
                catch (Exception)
                {

                }
            }
        }

        private List<CheckBox> GetCheckBoxes()
        {
            List<CheckBox> checkBoxes = new List<CheckBox>();
            foreach (Control control in extensions_panel.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    checkBoxes.Add((CheckBox)control);
                }
            }
            return checkBoxes;
        }

        private void btn_PerformAction_Click(object sender, EventArgs e)
        {
            List<string> extensions = new List<string>();

            foreach(CheckBox cb in GetCheckBoxes())
            {
                if(cb.Checked)
                {
                    extensions.Add(cb.Text);
                }
            }

            if (extensions.Count > 0)
            {
                if (rb_SwapAssets.Checked)
                {
                    PerformSwap(extensions);
                }
                else
                {
                    PerformRestore(extensions);
                }
            }
        }
    }
}
