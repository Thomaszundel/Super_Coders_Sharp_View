﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace SuperCoders_SharpView
{
    public partial class FormSharpView : Form
    {
        private int _pictureIndex = 0;
        string filePath;
        string filePathFull;
        string fileName;
        string[] files;
        bool remember;
        bool darkMode;
        bool splashScreen;
        //bool darkEnable;
        OptionsForm Options;
        public FormSharpView()
        {
            InitializeComponent();
        }
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";
            ofd.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                FileConfig(ofd.FileName);
                files = Directory.GetFiles(filePath);
                fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                GetPicNumber();
                SetNumLbl();
                ofd.Dispose();
            }
        }
        private void FileConfig(string FileName)
        {
            try
            {
                mnuFileClose.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                PicBoxMain.Image = Image.FromFile(FileName);
                lblName.Text = Path.GetFileNameWithoutExtension(FileName);
                filePath = Path.GetDirectoryName(FileName);
                filePathFull = Path.GetFullPath(FileName);
            }
            catch
            { 
                PicBoxMain = default;
            }
        }
        public void SetNumLbl()
        {
            int notBased = _pictureIndex + 1;
            lblImgNumber.Text = notBased + " / " + files.Length;
        }
        public void GetPicNumber()
        {
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains(fileName))
                {
                    _pictureIndex = i;
                    break;
                }
            }
        }
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuOptions_Click(object sender, EventArgs e)
        {
            Options.Show();
        }
        private void timerCheckDarkmode_Tick(object sender, EventArgs e)
        {
            //OptionsForm Options = new OptionsForm(ref remember);

            //OptionsForm Optionsd = new OptionsForm(ref darkEnable);
            //if (darkEnable = Optionsd.GetDark() = true)
            //{

            //    this.BackColor = ColorTranslator.FromHtml("#626262");
                //    menuStrip2.BackColor = ColorTranslator.FromHtml("#626262");
                //    mnuOptions.BackColor = ColorTranslator.FromHtml("#626262");
                //    mnuOptions.ForeColor = Color.White;



            //}
            //else
            //{
            //    this.BackColor = Color.White;
                //    menuStrip2.BackColor = Color.White;
                //    mnuOptions.BackColor = Color.White;
                //    mnuOptions.ForeColor = Color.Black;



            //}
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            //**get files from directory**
            string[] files = Directory.GetFiles(filePath);
            _pictureIndex++;
            if (_pictureIndex >= files.Length)
            {
                _pictureIndex = 0;
            }
            //**load pictureBox**
            PicBoxMain.Image = Image.FromFile(files[_pictureIndex]);
            //**clear label and load with new file name**
            lblName.Text = "";
            lblName.Text = Path.GetFileNameWithoutExtension(files[_pictureIndex]);
            filePathFull = Path.GetFullPath(files[_pictureIndex]);
            SetNumLbl();
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            mnuFileClose.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            PicBoxMain.Image.Dispose();
            PicBoxMain.Image = null;
            lblName.Text = "";
            lblImgNumber.Text = "";
        }
        private void FormSharpView_Load(object sender, EventArgs e)
        {
            string rememberResult = ConfigurationManager.AppSettings["RememberPhoto"];
            string darkResult = ConfigurationManager.AppSettings["DarkMode"];
            string splashResult = ConfigurationManager.AppSettings["SplashScreen"];
            if (rememberResult == "True")
                remember = true;
            else
                remember = false;

            if (darkResult == "True")
                darkMode = true;
            else
                darkMode = false;

            if (splashResult == "True")
                splashScreen = true;
            else
                splashScreen = false;

            Options = new OptionsForm(ref remember, ref darkMode, ref splashScreen);
            Options.Hide();
            string lastPhoto = LoadLastPhoto();
            lblName.Text = "";
            lblImgNumber.Text = "";
            if (lastPhoto != null)
            {
                try
                {
                    FileConfig(lastPhoto);
                    files = Directory.GetFiles(filePath);
                    fileName = Path.GetFileNameWithoutExtension(lastPhoto);
                    GetPicNumber();
                    SetNumLbl();
                }
                catch
                {
                    PicBoxMain = default;
                }
            }           
                    
        }

        private void FormSharpView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save(filePathFull);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //**get files from directory**
            string[] files = Directory.GetFiles(filePath);

            _pictureIndex--;
            if (_pictureIndex < 0)
            {
                _pictureIndex = files.Length - 1;
            }
            //**load pictureBox**
            PicBoxMain.Image = Image.FromFile(files[_pictureIndex]);
            //**clear label and load with new file name**
            lblName.Text = "";
            lblName.Text = Path.GetFileNameWithoutExtension(files[_pictureIndex]);
            filePathFull = Path.GetFullPath(files[_pictureIndex]);
            SetNumLbl();
        }

        public void Save(string lastPhoto)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            app.Settings.Clear();
            remember = Options.GetRemember();
            darkMode = Options.GetDark();
            splashScreen = Options.GetSplash();
            if (remember == true)
                app.Settings.Add("LastPhoto", lastPhoto);
            if (darkMode == true)
                app.Settings.Add("DarkMode", this.darkMode.ToString());
            if (splashScreen == true)
                app.Settings.Add("SplashScreen", this.splashScreen.ToString());
            app.Settings.Add("RememberPhoto", this.remember.ToString());
            config.Save(ConfigurationSaveMode.Minimal);
        }
        private string LoadLastPhoto()
        {
            remember = Options.GetRemember();
            string lastPhoto = null;
            if (remember == true)
            {
                string result = ConfigurationManager.AppSettings["LastPhoto"];
                if (result != null && result != "")
                {
                    lastPhoto = result;
                }
            }
            else
            {
                lastPhoto = null;
            }
            return lastPhoto;
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //***open folder dialog and set start up path***//
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select a folder";
            fbd.SelectedPath = Application.StartupPath;
            fbd.ShowNewFolderButton = false;
            if (DialogResult.OK == fbd.ShowDialog())
            {
                _pictureIndex = 0;
                mnuFileClose.Enabled = true;
                files = Directory.GetFiles(fbd.SelectedPath, "*.*");
                PicBoxMain.Image = Image.FromFile(files[_pictureIndex]);
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                lblName.Text = Path.GetFileNameWithoutExtension(files[_pictureIndex]);
                filePath = Path.GetDirectoryName(files[_pictureIndex]);
                SetNumLbl();
                fbd.Dispose();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.L)
            {
                btnLast.PerformClick();
                return true;
            }
            if (keyData == Keys.N)
            {
                btnLast.PerformClick();
                return true;
            }

            //capture left arrow key
            if (keyData == Keys.Left)
            {
                btnLast.PerformClick();
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                btnNext.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
