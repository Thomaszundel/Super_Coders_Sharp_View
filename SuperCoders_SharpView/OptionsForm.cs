using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperCoders_SharpView.Properties;
using System.IO;

namespace SuperCoders_SharpView
{
    public partial class OptionsForm : Form
    {
        bool remember = false;
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void checkBoxEnableSplashScreen_CheckedChanged(object sender, EventArgs e)
        {
            SplashScreen splash = new SplashScreen();
            splash.Enabled = false;
        }

        private void checkBoxRememberLast_CheckedChanged(object sender, EventArgs e)
        {   
            if (checkBoxRememberLast.Checked == true)
            {
                remember = true;
            } else
            {
                remember = false;
            }
        }

        public void checkBoxDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            bool darkEnable;
            if (checkBoxDarkMode.Checked)
            {
                darkEnable = true;
                this.BackColor = ColorTranslator.FromHtml("#626262");
                checkBoxDarkMode.BackColor = ColorTranslator.FromHtml("#626262");
                checkBoxEnableSplashScreen.ForeColor = Color.White;
                checkBoxRememberLast.ForeColor = Color.White;
                checkBoxDarkMode.ForeColor = Color.White;
                labelCredits.ForeColor = Color.White;

            }
            else
            {
                darkEnable = false;
                this.BackColor = Color.White;
                checkBoxDarkMode.BackColor = Color.White;
                checkBoxEnableSplashScreen.ForeColor = Color.Black;
                checkBoxRememberLast.ForeColor = Color.Black;
                checkBoxDarkMode.ForeColor = Color.Black;
                labelCredits.ForeColor = Color.Black;

            }
            
        }

        private void checkBoxDarkMode_Click(object sender, EventArgs e)
        {

        }

        public void Save(string lastPhoto)
        {
            remember = true;
            if (remember == true)
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\boyli\Source\Repos\Super_Coders_Sharp_View\SuperCoders_SharpView\Resources\LastUsed.txt"))
                {
                    sw.Write("");
                    sw.WriteLine(lastPhoto);
                }

                // save last filepath
            }
        }
        public string LoadLastPhoto()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\boyli\Source\Repos\Super_Coders_Sharp_View\SuperCoders_SharpView\Resources\LastUsed.txt"))
            {
                string lastPhoto = sr.ReadLine().ToString();
                return lastPhoto;
            }
        }

    }
}
