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

namespace SuperCoders_SharpView
{
    public partial class OptionsForm : Form
    {
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
            //really have no idea where to start here :\
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
    }
}
