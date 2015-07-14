namespace AssetSwapper
{
    partial class AssetSwapper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_SwapAssets = new System.Windows.Forms.RadioButton();
            this.rb_RestoreAssets = new System.Windows.Forms.RadioButton();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.btn_PerformAction = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.extensions_panel = new System.Windows.Forms.Panel();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.extensions_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_SwapAssets
            // 
            this.rb_SwapAssets.AutoSize = true;
            this.rb_SwapAssets.Checked = true;
            this.rb_SwapAssets.Location = new System.Drawing.Point(12, 12);
            this.rb_SwapAssets.Name = "rb_SwapAssets";
            this.rb_SwapAssets.Size = new System.Drawing.Size(86, 17);
            this.rb_SwapAssets.TabIndex = 0;
            this.rb_SwapAssets.TabStop = true;
            this.rb_SwapAssets.Text = "Swap Assets";
            this.rb_SwapAssets.UseVisualStyleBackColor = true;
            this.rb_SwapAssets.CheckedChanged += new System.EventHandler(this.rb_SwapAssets_CheckedChanged);
            // 
            // rb_RestoreAssets
            // 
            this.rb_RestoreAssets.AutoSize = true;
            this.rb_RestoreAssets.Location = new System.Drawing.Point(135, 12);
            this.rb_RestoreAssets.Name = "rb_RestoreAssets";
            this.rb_RestoreAssets.Size = new System.Drawing.Size(96, 17);
            this.rb_RestoreAssets.TabIndex = 1;
            this.rb_RestoreAssets.Text = "Restore Assets";
            this.rb_RestoreAssets.UseVisualStyleBackColor = true;
            this.rb_RestoreAssets.CheckedChanged += new System.EventHandler(this.rb_RestoreAssets_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(3, 26);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(49, 17);
            this.checkBox9.TabIndex = 2;
            this.checkBox9.Text = ".mp3";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(56, 95);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(49, 17);
            this.checkBox10.TabIndex = 3;
            this.checkBox10.Text = ".mp4";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // btn_PerformAction
            // 
            this.btn_PerformAction.Location = new System.Drawing.Point(12, 244);
            this.btn_PerformAction.Name = "btn_PerformAction";
            this.btn_PerformAction.Size = new System.Drawing.Size(219, 23);
            this.btn_PerformAction.TabIndex = 9;
            this.btn_PerformAction.Text = "Swap";
            this.btn_PerformAction.UseVisualStyleBackColor = true;
            this.btn_PerformAction.Click += new System.EventHandler(this.btn_PerformAction_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = ".aa3";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(109, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = ".aif";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(56, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = ".ac3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(162, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(46, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = ".flac";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(109, 26);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(47, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = ".pca";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(162, 26);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(49, 17);
            this.checkBox6.TabIndex = 15;
            this.checkBox6.Text = ".w64";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(3, 49);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(49, 17);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.Text = ".wav";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(56, 49);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(51, 17);
            this.checkBox8.TabIndex = 17;
            this.checkBox8.Text = ".wma";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(109, 95);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(49, 17);
            this.checkBox11.TabIndex = 18;
            this.checkBox11.Text = ".mpg";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(162, 95);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(43, 17);
            this.checkBox12.TabIndex = 19;
            this.checkBox12.Text = ".avi";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(3, 118);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(51, 17);
            this.checkBox13.TabIndex = 20;
            this.checkBox13.Text = ".wmv";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(56, 26);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(47, 17);
            this.checkBox14.TabIndex = 21;
            this.checkBox14.Text = ".ogg";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(3, 164);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(49, 17);
            this.checkBox16.TabIndex = 23;
            this.checkBox16.Text = ".bmp";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(109, 164);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(43, 17);
            this.checkBox15.TabIndex = 24;
            this.checkBox15.Text = ".jpg";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(162, 164);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(47, 17);
            this.checkBox17.TabIndex = 25;
            this.checkBox17.Text = ".png";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(56, 164);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(40, 17);
            this.checkBox18.TabIndex = 26;
            this.checkBox18.Text = ".gif";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(3, 187);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(37, 17);
            this.checkBox19.TabIndex = 27;
            this.checkBox19.Text = ".tif";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // extensions_panel
            // 
            this.extensions_panel.Controls.Add(this.checkBox20);
            this.extensions_panel.Controls.Add(this.checkBox1);
            this.extensions_panel.Controls.Add(this.checkBox19);
            this.extensions_panel.Controls.Add(this.checkBox9);
            this.extensions_panel.Controls.Add(this.checkBox18);
            this.extensions_panel.Controls.Add(this.checkBox10);
            this.extensions_panel.Controls.Add(this.checkBox17);
            this.extensions_panel.Controls.Add(this.checkBox2);
            this.extensions_panel.Controls.Add(this.checkBox15);
            this.extensions_panel.Controls.Add(this.checkBox3);
            this.extensions_panel.Controls.Add(this.checkBox16);
            this.extensions_panel.Controls.Add(this.checkBox4);
            this.extensions_panel.Controls.Add(this.checkBox14);
            this.extensions_panel.Controls.Add(this.checkBox5);
            this.extensions_panel.Controls.Add(this.checkBox13);
            this.extensions_panel.Controls.Add(this.checkBox6);
            this.extensions_panel.Controls.Add(this.checkBox12);
            this.extensions_panel.Controls.Add(this.checkBox7);
            this.extensions_panel.Controls.Add(this.checkBox11);
            this.extensions_panel.Controls.Add(this.checkBox8);
            this.extensions_panel.Location = new System.Drawing.Point(12, 32);
            this.extensions_panel.Name = "extensions_panel";
            this.extensions_panel.Size = new System.Drawing.Size(219, 206);
            this.extensions_panel.TabIndex = 28;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(3, 95);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(43, 17);
            this.checkBox20.TabIndex = 28;
            this.checkBox20.Text = ".bik";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // AssetSwapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 278);
            this.Controls.Add(this.extensions_panel);
            this.Controls.Add(this.btn_PerformAction);
            this.Controls.Add(this.rb_RestoreAssets);
            this.Controls.Add(this.rb_SwapAssets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssetSwapper";
            this.ShowIcon = false;
            this.Text = "Asset Swapper";
            this.extensions_panel.ResumeLayout(false);
            this.extensions_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_SwapAssets;
        private System.Windows.Forms.RadioButton rb_RestoreAssets;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Button btn_PerformAction;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.Panel extensions_panel;
        private System.Windows.Forms.CheckBox checkBox20;
    }
}

