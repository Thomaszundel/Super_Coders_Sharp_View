using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void checkBoxDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            OptionsForm opt = new OptionsForm();
            if (checkBoxDarkMode.Checked)
            {
                
                opt.BackColor = Color.DimGray;
                checkBoxEnableSplashScreen.BackColor = Color.DimGray;
            }
            else
            {
                opt.BackColor = Color.White;
                checkBoxEnableSplashScreen.BackColor = Color.White;
            }
            opt.Refresh();
        }
    }
}
