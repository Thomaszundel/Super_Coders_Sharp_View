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
        private string filepath = Environment.CurrentDirectory + "\\Desktop images";
        public FormSharpView()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";



            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                // change this in properties
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                PicBoxMain.Image = Image.FromFile(ofd.FileName);
            }
        }
        
    }
}
