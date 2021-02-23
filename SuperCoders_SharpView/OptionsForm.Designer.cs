namespace SuperCoders_SharpView
{
    partial class OptionsForm
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
            this.checkBoxEnableSplashScreen = new System.Windows.Forms.CheckBox();
            this.checkBoxRememberLast = new System.Windows.Forms.CheckBox();
            this.checkBoxDarkMode = new System.Windows.Forms.CheckBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxEnableSplashScreen
            // 
            this.checkBoxEnableSplashScreen.AutoSize = true;
            this.checkBoxEnableSplashScreen.Location = new System.Drawing.Point(87, 51);
            this.checkBoxEnableSplashScreen.Name = "checkBoxEnableSplashScreen";
            this.checkBoxEnableSplashScreen.Size = new System.Drawing.Size(136, 17);
            this.checkBoxEnableSplashScreen.TabIndex = 0;
            this.checkBoxEnableSplashScreen.Text = "Splash Screen enabled";
            this.checkBoxEnableSplashScreen.UseVisualStyleBackColor = true;
            this.checkBoxEnableSplashScreen.CheckedChanged += new System.EventHandler(this.checkBoxEnableSplashScreen_CheckedChanged);
            // 
            // checkBoxRememberLast
            // 
            this.checkBoxRememberLast.AutoSize = true;
            this.checkBoxRememberLast.Location = new System.Drawing.Point(87, 111);
            this.checkBoxRememberLast.Name = "checkBoxRememberLast";
            this.checkBoxRememberLast.Size = new System.Drawing.Size(195, 17);
            this.checkBoxRememberLast.TabIndex = 1;
            this.checkBoxRememberLast.Text = "Remember the last directory chosen";
            this.checkBoxRememberLast.UseVisualStyleBackColor = true;
            this.checkBoxRememberLast.CheckedChanged += new System.EventHandler(this.checkBoxRememberLast_CheckedChanged);
            // 
            // checkBoxDarkMode
            // 
            this.checkBoxDarkMode.AutoSize = true;
            this.checkBoxDarkMode.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxDarkMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxDarkMode.Location = new System.Drawing.Point(87, 178);
            this.checkBoxDarkMode.Name = "checkBoxDarkMode";
            this.checkBoxDarkMode.Size = new System.Drawing.Size(79, 17);
            this.checkBoxDarkMode.TabIndex = 2;
            this.checkBoxDarkMode.Text = "Dark Mode";
            this.checkBoxDarkMode.UseVisualStyleBackColor = false;
            this.checkBoxDarkMode.CheckedChanged += new System.EventHandler(this.checkBoxDarkMode_CheckedChanged);
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelCredits.Location = new System.Drawing.Point(12, 244);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(297, 13);
            this.labelCredits.TabIndex = 3;
            this.labelCredits.Text = "Copyright 2021 by SuperCoders  All Rights Reserved Probably";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 276);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.checkBoxDarkMode);
            this.Controls.Add(this.checkBoxRememberLast);
            this.Controls.Add(this.checkBoxEnableSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEnableSplashScreen;
        private System.Windows.Forms.CheckBox checkBoxRememberLast;
        private System.Windows.Forms.CheckBox checkBoxDarkMode;
        private System.Windows.Forms.Label labelCredits;
    }
}