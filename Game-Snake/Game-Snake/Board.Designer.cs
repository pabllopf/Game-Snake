namespace Snake
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.scoreName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.scoreValue = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.pressStart = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Label();
            this.labelrecord = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pbCanvas, "pbCanvas");
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCanvas_Paint);
            // 
            // scoreName
            // 
            resources.ApplyResources(this.scoreName, "scoreName");
            this.scoreName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreName.Name = "scoreName";
            // 
            // lblScore
            // 
            resources.ApplyResources(this.lblScore, "lblScore");
            this.lblScore.Name = "lblScore";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            resources.ApplyResources(this.gameToolStripMenuItem, "gameToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // scoreValue
            // 
            resources.ApplyResources(this.scoreValue, "scoreValue");
            this.scoreValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreValue.Name = "scoreValue";
            // 
            // gameOver
            // 
            resources.ApplyResources(this.gameOver, "gameOver");
            this.gameOver.Name = "gameOver";
            // 
            // pressStart
            // 
            resources.ApplyResources(this.pressStart, "pressStart");
            this.pressStart.Name = "pressStart";
            // 
            // welcome
            // 
            resources.ApplyResources(this.welcome, "welcome");
            this.welcome.Name = "welcome";
            // 
            // pause
            // 
            resources.ApplyResources(this.pause, "pause");
            this.pause.Name = "pause";
            // 
            // labelrecord
            // 
            resources.ApplyResources(this.labelrecord, "labelrecord");
            this.labelrecord.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelrecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelrecord.Name = "labelrecord";
            // 
            // record
            // 
            resources.ApplyResources(this.record, "record");
            this.record.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.record.Name = "record";
            // 
            // Board
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.record);
            this.Controls.Add(this.labelrecord);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.pressStart);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.scoreName);
            this.Controls.Add(this.scoreValue);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Board";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Board_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label scoreName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label scoreValue;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Label pressStart;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label pause;
        private System.Windows.Forms.Label labelrecord;
        private System.Windows.Forms.Label record;
    }
}

