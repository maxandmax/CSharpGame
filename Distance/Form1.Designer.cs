namespace Distance
{
    partial class Game1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.t_mvObj = new System.Windows.Forms.Timer(this.components);
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gameBegin = new System.Windows.Forms.ToolStripMenuItem();
            this.endGame = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.counter = new System.Windows.Forms.Label();
            this.t_Count = new System.Windows.Forms.Timer(this.components);
            this.lvlbl = new System.Windows.Forms.Label();
            this.bad = new System.Windows.Forms.Label();
            this.good = new System.Windows.Forms.Label();
            this.soundlbl = new System.Windows.Forms.Label();
            this.showInfo = new System.Windows.Forms.Timer(this.components);
            this.label1_info = new System.Windows.Forms.Label();
            this.mMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_mvObj
            // 
            this.t_mvObj.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mMenu
            // 
            this.mMenu.BackColor = System.Drawing.Color.Transparent;
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(780, 24);
            this.mMenu.TabIndex = 10;
            this.mMenu.Text = "menuStrip1";
            // 
            // mainMenu
            // 
            this.mainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameBegin,
            this.endGame,
            this.settings,
            this.обАвтореToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.mainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(53, 20);
            this.mainMenu.Text = "Меню";
            // 
            // gameBegin
            // 
            this.gameBegin.Image = ((System.Drawing.Image)(resources.GetObject("gameBegin.Image")));
            this.gameBegin.Name = "gameBegin";
            this.gameBegin.Size = new System.Drawing.Size(136, 22);
            this.gameBegin.Text = "Играть";
            this.gameBegin.Click += new System.EventHandler(this.начатьИгруToolStripMenuItem_Click);
            // 
            // endGame
            // 
            this.endGame.Enabled = false;
            this.endGame.Image = ((System.Drawing.Image)(resources.GetObject("endGame.Image")));
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(136, 22);
            this.endGame.Text = "Закончить";
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // settings
            // 
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(136, 22);
            this.settings.Text = "Настройки";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обАвтореToolStripMenuItem.Image")));
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem1.Image")));
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.выходToolStripMenuItem1.Text = "Выход (Esc)";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.Location = new System.Drawing.Point(227, 289);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(330, 161);
            this.infoPanel.TabIndex = 18;
            // 
            // counter
            // 
            this.counter.BackColor = System.Drawing.Color.Transparent;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.counter.ForeColor = System.Drawing.Color.White;
            this.counter.Location = new System.Drawing.Point(0, 89);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(780, 76);
            this.counter.TabIndex = 20;
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_Count
            // 
            this.t_Count.Interval = 300;
            this.t_Count.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lvlbl
            // 
            this.lvlbl.BackColor = System.Drawing.Color.Transparent;
            this.lvlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvlbl.ForeColor = System.Drawing.Color.Black;
            this.lvlbl.Location = new System.Drawing.Point(224, 24);
            this.lvlbl.Name = "lvlbl";
            this.lvlbl.Size = new System.Drawing.Size(72, 37);
            this.lvlbl.TabIndex = 22;
            this.lvlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bad
            // 
            this.bad.BackColor = System.Drawing.Color.Transparent;
            this.bad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bad.ForeColor = System.Drawing.Color.Red;
            this.bad.Location = new System.Drawing.Point(473, 24);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(84, 37);
            this.bad.TabIndex = 15;
            this.bad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // good
            // 
            this.good.BackColor = System.Drawing.Color.Transparent;
            this.good.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.good.ForeColor = System.Drawing.Color.LimeGreen;
            this.good.Location = new System.Drawing.Point(390, 24);
            this.good.Name = "good";
            this.good.Size = new System.Drawing.Size(84, 37);
            this.good.TabIndex = 14;
            this.good.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soundlbl
            // 
            this.soundlbl.BackColor = System.Drawing.Color.Transparent;
            this.soundlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundlbl.Enabled = false;
            this.soundlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soundlbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.soundlbl.Location = new System.Drawing.Point(295, 24);
            this.soundlbl.Name = "soundlbl";
            this.soundlbl.Size = new System.Drawing.Size(52, 37);
            this.soundlbl.TabIndex = 23;
            this.soundlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.soundlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // showInfo
            // 
            this.showInfo.Tick += new System.EventHandler(this.showInfo_Tick);
            // 
            // label1_info
            // 
            this.label1_info.BackColor = System.Drawing.Color.Transparent;
            this.label1_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1_info.Enabled = false;
            this.label1_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_info.Location = new System.Drawing.Point(344, 24);
            this.label1_info.Name = "label1_info";
            this.label1_info.Size = new System.Drawing.Size(49, 37);
            this.label1_info.TabIndex = 25;
            this.label1_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1_info.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 758);
            this.Controls.Add(this.label1_info);
            this.Controls.Add(this.soundlbl);
            this.Controls.Add(this.lvlbl);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.good);
            this.Controls.Add(this.mMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mMenu;
            this.MaximizeBox = false;
            this.Name = "Game1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catch";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer t_mvObj;
        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mainMenu;
        private System.Windows.Forms.ToolStripMenuItem gameBegin;
        private System.Windows.Forms.ToolStripMenuItem endGame;
        private System.Windows.Forms.Label good;
        private System.Windows.Forms.Label bad;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Timer t_Count;
        private System.Windows.Forms.Label lvlbl;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.Label soundlbl;
        private System.Windows.Forms.Timer showInfo;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.Label label1_info;
    }
}

