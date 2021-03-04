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
        bool splashDisable;
        public OptionsForm(ref bool mainRemember, ref bool mainDarkEnable, ref bool mainSplashDisable)
        {
            InitializeComponent();
            remember = mainRemember;
            darkEnable = mainDarkEnable;
            splashDisable = mainSplashDisable;
        }
        private void checkboxDisableSplashScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxDisableSplashScreen.Checked == true)
                splashDisable = true;
            else
                splashDisable = false;
        }
        private void checkBoxRememberLast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRememberLast.Checked == true)
                remember = true;
            else
                remember = false;
        }
        public void checkBoxDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDarkMode.Checked)
            {
                darkEnable = true;
                this.BackColor = ColorTranslator.FromHtml("#404040");
                checkBoxDarkMode.BackColor = ColorTranslator.FromHtml("#404040");
                checkboxDisableSplashScreen.ForeColor = ColorTranslator.FromHtml("#d9d9d9");
                checkBoxRememberLast.ForeColor = ColorTranslator.FromHtml("#d9d9d9");
                checkBoxDarkMode.ForeColor = ColorTranslator.FromHtml("#d9d9d9");
                labelCredits.ForeColor = ColorTranslator.FromHtml("#d9d9d9");
                btnOK.BackColor = ColorTranslator.FromHtml("#737373");
                btnOK.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
            else
            {
                darkEnable = false;
                this.BackColor = ColorTranslator.FromHtml("#f2f2f2");
                checkBoxDarkMode.BackColor = ColorTranslator.FromHtml("#f2f2f2");
                checkboxDisableSplashScreen.ForeColor = Color.Black;
                checkBoxRememberLast.ForeColor = Color.Black;
                checkBoxDarkMode.ForeColor = Color.Black;
                labelCredits.ForeColor = Color.Black;
                btnOK.BackColor = Color.White;
                btnOK.ForeColor = Color.Black;
            }
        }
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            if (splashDisable == true)
                checkboxDisableSplashScreen.Checked = true;
            else
                checkboxDisableSplashScreen.Checked = false;
            if (remember == true)
                checkBoxRememberLast.Checked = true;
            else
                checkBoxRememberLast.Checked = false;
            if (darkEnable == true)
                checkBoxDarkMode.Checked = true;
            else
                checkBoxDarkMode.Checked = false;
        }
        public bool GetRemember()
        {
            return remember;
        }
        public bool GetDark()
        {
            return darkEnable;
        }
        public bool GetSplash()
        {
            return splashDisable;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (e.CloseReason == CloseReason.ApplicationExitCall) return;
            e.Cancel = true;
            this.Hide();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
