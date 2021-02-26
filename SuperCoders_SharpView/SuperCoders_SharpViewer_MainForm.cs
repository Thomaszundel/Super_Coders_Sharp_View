using System;
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
            mnuFileClose.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            PicBoxMain.Image = Image.FromFile(FileName);
            lblName.Text = Path.GetFileNameWithoutExtension(FileName);
            filePath = Path.GetDirectoryName(FileName);
            filePathFull = Path.GetFullPath(FileName);
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
            OptionsForm Options = new OptionsForm(ref remember);

            //if (Options.darkEnable == true)
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
            string result = ConfigurationManager.AppSettings["RememberPhoto"];
            if (result == "True")
            {
                remember = true;
            } else
            {
                remember = false;
            }
            Options = new OptionsForm(ref remember);
            Options.Hide();
            string lastPhoto = LoadLastPhoto();
            if (lastPhoto != null)
            {
                FileConfig(lastPhoto);
                files = Directory.GetFiles(filePath);
                fileName = Path.GetFileNameWithoutExtension(lastPhoto);
                GetPicNumber();
                SetNumLbl();
            }           
            lblName.Text = "";
            lblImgNumber.Text = "";          
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
            SetNumLbl();
        }

        public void Save(string lastPhoto)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            app.Settings.Clear();
            remember = Options.GetRemember();
            if (remember == true)
            {
                app.Settings.Add("LastPhoto", lastPhoto);                
            }
            app.Settings.Add("RememberPhoto", this.remember.ToString());
            config.Save(ConfigurationSaveMode.Minimal);
            string result = ConfigurationManager.AppSettings["RememberPhoto"];
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
    }
}
