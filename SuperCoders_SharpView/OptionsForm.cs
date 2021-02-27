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
using System.Configuration;

namespace SuperCoders_SharpView
{
    public partial class OptionsForm : Form
    {
        bool remember;
        bool darkEnable;
        public OptionsForm(ref bool mainRemember/*, ref bool mainDarkEnable*/)
        {
            InitializeComponent();
            remember = mainRemember;
            //darkEnable = mainDarkEnable;
        }

        //public OptionsForm(ref bool mainDarkEnable)
        //{
        //    InitializeComponent();
        //    darkEnable = mainDarkEnable;
        //}

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
            }
            else
            {
                remember = false;
            }
        }

        public bool GetDark()
        {
            return darkEnable;
        }

        public void checkBoxDarkMode_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxDarkMode.Checked)
            {
                darkEnable = true;
                this.BackColor = ColorTranslator.FromHtml("#626262");
                //    checkBoxDarkMode.BackColor = ColorTranslator.FromHtml("#626262");
                //    checkBoxEnableSplashScreen.ForeColor = Color.White;
                //    checkBoxRememberLast.ForeColor = Color.White;
                //    checkBoxDarkMode.ForeColor = Color.White;
                //    labelCredits.ForeColor = Color.White;

            }
            else
            {
                darkEnable = false;
                this.BackColor = Color.White;
                //    checkBoxDarkMode.BackColor = Color.White;
                //    checkBoxEnableSplashScreen.ForeColor = Color.Black;
                //    checkBoxRememberLast.ForeColor = Color.Black;
                //    checkBoxDarkMode.ForeColor = Color.Black;
                //    labelCredits.ForeColor = Color.Black;

            }

        }


        private void OptionsForm_Load(object sender, EventArgs e)
        {
            if (remember == true)
                checkBoxRememberLast.Checked = true;
            else
                checkBoxRememberLast.Checked = false;


            if (darkEnable == true)
                checkBoxDarkMode.Checked = true;
            else
                checkBoxRememberLast.Checked = false;
        }

        public bool GetRemember()
        {
            return remember;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            
            e.Cancel = true;
            this.Hide();
        }
    }
}
