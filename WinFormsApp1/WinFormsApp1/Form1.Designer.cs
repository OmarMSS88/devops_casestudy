namespace WinFormsApp1
{
    partial class frmCoinToss
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoinToss));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkmodeToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.nightmareToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatorInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGO = new System.Windows.Forms.Button();
            this.lblMedium = new System.Windows.Forms.Label();
            this.btnHeads = new System.Windows.Forms.Button();
            this.btnTails = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLives = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(342, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkmodeToggle,
            this.nightmareToggle});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // darkmodeToggle
            // 
            this.darkmodeToggle.CheckOnClick = true;
            this.darkmodeToggle.Name = "darkmodeToggle";
            this.darkmodeToggle.Size = new System.Drawing.Size(165, 22);
            this.darkmodeToggle.Text = "Darkmode";
            // 
            // nightmareToggle
            // 
            this.nightmareToggle.CheckOnClick = true;
            this.nightmareToggle.Name = "nightmareToggle";
            this.nightmareToggle.Size = new System.Drawing.Size(165, 22);
            this.nightmareToggle.Text = "Nightmare Mode";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatorInfo});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // CreatorInfo
            // 
            this.CreatorInfo.Name = "CreatorInfo";
            this.CreatorInfo.Size = new System.Drawing.Size(180, 22);
            this.CreatorInfo.Text = "Creator";
            this.CreatorInfo.Click += new System.EventHandler(this.CreatorInfo_Click);
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(135, 191);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 1;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedium.Location = new System.Drawing.Point(84, 103);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(184, 38);
            this.lblMedium.TabIndex = 2;
            this.lblMedium.Text = "COIN TOSS";
            this.lblMedium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHeads
            // 
            this.btnHeads.Location = new System.Drawing.Point(12, 241);
            this.btnHeads.Name = "btnHeads";
            this.btnHeads.Size = new System.Drawing.Size(75, 23);
            this.btnHeads.TabIndex = 3;
            this.btnHeads.Text = "Heads";
            this.btnHeads.UseVisualStyleBackColor = true;
            this.btnHeads.Click += new System.EventHandler(this.btnHeads_Click);
            // 
            // btnTails
            // 
            this.btnTails.Location = new System.Drawing.Point(255, 241);
            this.btnTails.Name = "btnTails";
            this.btnTails.Size = new System.Drawing.Size(75, 23);
            this.btnTails.TabIndex = 4;
            this.btnTails.Text = "Tails";
            this.btnTails.UseVisualStyleBackColor = true;
            this.btnTails.Click += new System.EventHandler(this.btnTails_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Location = new System.Drawing.Point(12, 48);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(36, 15);
            this.lblLives.TabIndex = 5;
            this.lblLives.Text = "lives: ";
            // 
            // frmCoinToss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 283);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.btnTails);
            this.Controls.Add(this.btnHeads);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "frmCoinToss";
            this.Text = "COIN TOSS";
            this.Load += new System.EventHandler(this.frmCoinToss_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem darkmodeToggle;
        private ToolStripMenuItem nightmareToggle;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem CreatorInfo;
        private Button btnGO;
        private Label lblMedium;
        private Button btnHeads;
        private Button btnTails;
        private System.Windows.Forms.Timer timer1;
        private Label lblLives;
    }
}