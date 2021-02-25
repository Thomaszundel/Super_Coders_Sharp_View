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
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection app = config.AppSettings;
                app.Settings.Clear();
                app.Settings.Add("LastPhoto", lastPhoto);
                config.Save(ConfigurationSaveMode.Minimal);
            }
        }
        public string LoadLastPhoto()
        {
            string lastPhoto = null;
            remember = true;
            if (remember == true)
            {             
                string result = ConfigurationManager.AppSettings["LastPhoto"];
                if (result != null && result != "")
                {
                    lastPhoto = result;                  
                }
            } else
            {
                lastPhoto = null;
            }
            return lastPhoto;
        }

    }
}
