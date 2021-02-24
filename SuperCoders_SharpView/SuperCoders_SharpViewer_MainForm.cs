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

namespace SuperCoders_SharpView
{
    public partial class FormSharpView : Form
    {
        private int _pictureIndex = 0;
        string filePath;
        public FormSharpView()
        {
            InitializeComponent();
        }
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                PicBoxMain.Image = Image.FromFile(ofd.FileName);
                lblName.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                filePath = Path.GetDirectoryName(ofd.FileName);
            }
        }
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnuOptions_Click(object sender, EventArgs e)
        {
            OptionsForm Options = new OptionsForm();
            Options.Show();
        }
        private void timerCheckDarkmode_Tick(object sender, EventArgs e)
        {
            OptionsForm Options = new OptionsForm();

            if (Options.darkEnable == true)
            {

                this.BackColor = ColorTranslator.FromHtml("#626262");
                menuStrip2.BackColor = ColorTranslator.FromHtml("#626262");
                mnuOptions.BackColor = ColorTranslator.FromHtml("#626262");
                mnuOptions.ForeColor = Color.White;



            }
            else
            {
                this.BackColor = Color.White;
                menuStrip2.BackColor = Color.White;
                mnuOptions.BackColor = Color.White;
                mnuOptions.ForeColor = Color.Black;



            }
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
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            PicBoxMain.Image = null;
            lblName.Text = "";
        }
        private void FormSharpView_Load(object sender, EventArgs e)
        {
            lblName.Text = "";
            lblImgNumber.Text = "";
        }
    }
}
