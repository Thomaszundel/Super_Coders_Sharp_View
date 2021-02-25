
namespace SuperCoders_SharpView
{
    partial class FormSharpView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSharpView));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.PicBoxMain = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblImgNumber = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.timerCheckDarkmode = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuOptions});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(804, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileClose,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size(180, 22);
            this.mnuFileClose.Text = "Close";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "Exit ";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
            // 
            // PicBoxMain
            // 
            this.PicBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBoxMain.Location = new System.Drawing.Point(0, 24);
            this.PicBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.PicBoxMain.Name = "PicBoxMain";
            this.PicBoxMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.PicBoxMain.Size = new System.Drawing.Size(804, 537);
            this.PicBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxMain.TabIndex = 6;
            this.PicBoxMain.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(503, 536);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "label1";
            // 
            // lblImgNumber
            // 
            this.lblImgNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblImgNumber.AutoSize = true;
            this.lblImgNumber.Location = new System.Drawing.Point(153, 536);
            this.lblImgNumber.Name = "lblImgNumber";
            this.lblImgNumber.Size = new System.Drawing.Size(35, 13);
            this.lblImgNumber.TabIndex = 8;
            this.lblImgNumber.Text = "label2";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNext.Location = new System.Drawing.Point(376, 531);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "è";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLast.Enabled = false;
            this.btnLast.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnLast.Location = new System.Drawing.Point(252, 531);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "ç";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // ofdMain
            // 
            this.ofdMain.FileName = "openFileDialog1";
            this.ofdMain.InitialDirectory = "cmd \"D:\\Winter 2021\\IT111\\Group Project\\Sharp_View\\SuperCoders_SharpView\\bin\\Debu" +
    "g\\Desktop images";
            this.ofdMain.RestoreDirectory = true;
            // 
            // timerCheckDarkmode
            // 
            this.timerCheckDarkmode.Enabled = true;
            this.timerCheckDarkmode.Tick += new System.EventHandler(this.timerCheckDarkmode_Tick);
            // 
            // FormSharpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblImgNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.PicBoxMain);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 597);
            this.Name = "FormSharpView";
            this.Text = "Super Coder Sharp View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSharpView_FormClosing);
            this.Load += new System.EventHandler(this.FormSharpView_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.PictureBox PicBoxMain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblImgNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.Timer timerCheckDarkmode;
    }
}

