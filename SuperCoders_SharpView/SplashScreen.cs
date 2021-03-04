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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
            SplashTimer.Enabled = false;
        }
        private void pbSplash_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbSplash_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("Click to close", Font, Brushes.Black, 2, Height - 15);
        }
    }
}
