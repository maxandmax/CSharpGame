namespace Distance
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.errorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encreaseObj = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bg_color = new System.Windows.Forms.Label();
            this.rrrObj = new System.Windows.Forms.NumericUpDown();
            this.endBooster = new System.Windows.Forms.CheckBox();
            this.timerUse = new System.Windows.Forms.CheckBox();
            this.spObj = new System.Windows.Forms.NumericUpDown();
            this.noLandScapeObj = new System.Windows.Forms.CheckBox();
            this.noAnswerGame = new System.Windows.Forms.CheckBox();
            this.useAutoMove = new System.Windows.Forms.CheckBox();
            this.pDefault = new System.Windows.Forms.PictureBox();
            this.pRed = new System.Windows.Forms.PictureBox();
            this.pPink = new System.Windows.Forms.PictureBox();
            this.pGreen = new System.Windows.Forms.PictureBox();
            this.pBlue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.encreaseObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrrObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.Location = new System.Drawing.Point(12, 9);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(433, 67);
            this.errorLabel.TabIndex = 22;
            this.errorLabel.Text = "Настройки";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Количество воскрешающих объектов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // encreaseObj
            // 
            this.encreaseObj.Location = new System.Drawing.Point(347, 88);
            this.encreaseObj.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.encreaseObj.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.encreaseObj.Name = "encreaseObj";
            this.encreaseObj.Size = new System.Drawing.Size(98, 20);
            this.encreaseObj.TabIndex = 14;
            this.encreaseObj.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество объектов для отлова";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(15, 481);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(429, 44);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.Text = "Применить ";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Скорость объектов";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bg_color
            // 
            this.bg_color.Location = new System.Drawing.Point(12, 189);
            this.bg_color.Name = "bg_color";
            this.bg_color.Size = new System.Drawing.Size(435, 32);
            this.bg_color.TabIndex = 25;
            this.bg_color.Text = "Фон игры";
            this.bg_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rrrObj
            // 
            this.rrrObj.Location = new System.Drawing.Point(347, 120);
            this.rrrObj.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.rrrObj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rrrObj.Name = "rrrObj";
            this.rrrObj.Size = new System.Drawing.Size(98, 20);
            this.rrrObj.TabIndex = 30;
            this.rrrObj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endBooster
            // 
            this.endBooster.Location = new System.Drawing.Point(15, 251);
            this.endBooster.Name = "endBooster";
            this.endBooster.Size = new System.Drawing.Size(429, 37);
            this.endBooster.TabIndex = 32;
            this.endBooster.Text = "Использовать ускорение объектов";
            this.endBooster.UseVisualStyleBackColor = true;
            // 
            // timerUse
            // 
            this.timerUse.Location = new System.Drawing.Point(15, 294);
            this.timerUse.Name = "timerUse";
            this.timerUse.Size = new System.Drawing.Size(429, 37);
            this.timerUse.TabIndex = 33;
            this.timerUse.Text = "Использовать обратный отсчет";
            this.timerUse.UseVisualStyleBackColor = true;
            // 
            // spObj
            // 
            this.spObj.Location = new System.Drawing.Point(346, 151);
            this.spObj.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.spObj.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spObj.Name = "spObj";
            this.spObj.Size = new System.Drawing.Size(98, 20);
            this.spObj.TabIndex = 34;
            this.spObj.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // noLandScapeObj
            // 
            this.noLandScapeObj.Location = new System.Drawing.Point(16, 337);
            this.noLandScapeObj.Name = "noLandScapeObj";
            this.noLandScapeObj.Size = new System.Drawing.Size(429, 37);
            this.noLandScapeObj.TabIndex = 35;
            this.noLandScapeObj.Text = "Использовать ландшафтные объекты";
            this.noLandScapeObj.UseVisualStyleBackColor = true;
            // 
            // noAnswerGame
            // 
            this.noAnswerGame.Location = new System.Drawing.Point(15, 380);
            this.noAnswerGame.Name = "noAnswerGame";
            this.noAnswerGame.Size = new System.Drawing.Size(429, 37);
            this.noAnswerGame.TabIndex = 36;
            this.noAnswerGame.Text = "Использовать вопросы";
            this.noAnswerGame.UseVisualStyleBackColor = true;
            // 
            // useAutoMove
            // 
            this.useAutoMove.Location = new System.Drawing.Point(15, 423);
            this.useAutoMove.Name = "useAutoMove";
            this.useAutoMove.Size = new System.Drawing.Size(429, 37);
            this.useAutoMove.TabIndex = 38;
            this.useAutoMove.Text = "Пользователь сам двигает объект";
            this.useAutoMove.UseVisualStyleBackColor = true;
            // 
            // pDefault
            // 
            this.pDefault.Image = global::Distance.Properties.Resources.bg_default;
            this.pDefault.Location = new System.Drawing.Point(132, 189);
            this.pDefault.Name = "pDefault";
            this.pDefault.Size = new System.Drawing.Size(32, 32);
            this.pDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pDefault.TabIndex = 37;
            this.pDefault.TabStop = false;
            this.pDefault.Click += new System.EventHandler(this.chooseBackground);
            // 
            // pRed
            // 
            this.pRed.Image = global::Distance.Properties.Resources.bg_red;
            this.pRed.Location = new System.Drawing.Point(412, 189);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(32, 32);
            this.pRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pRed.TabIndex = 29;
            this.pRed.TabStop = false;
            this.pRed.Click += new System.EventHandler(this.chooseBackground);
            // 
            // pPink
            // 
            this.pPink.Image = global::Distance.Properties.Resources.bg_pink;
            this.pPink.Location = new System.Drawing.Point(346, 189);
            this.pPink.Name = "pPink";
            this.pPink.Size = new System.Drawing.Size(32, 32);
            this.pPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPink.TabIndex = 28;
            this.pPink.TabStop = false;
            this.pPink.Click += new System.EventHandler(this.chooseBackground);
            // 
            // pGreen
            // 
            this.pGreen.Image = global::Distance.Properties.Resources.bg_green;
            this.pGreen.Location = new System.Drawing.Point(276, 189);
            this.pGreen.Name = "pGreen";
            this.pGreen.Size = new System.Drawing.Size(32, 32);
            this.pGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pGreen.TabIndex = 27;
            this.pGreen.TabStop = false;
            this.pGreen.Click += new System.EventHandler(this.chooseBackground);
            // 
            // pBlue
            // 
            this.pBlue.Image = global::Distance.Properties.Resources.bg_blue;
            this.pBlue.Location = new System.Drawing.Point(204, 189);
            this.pBlue.Name = "pBlue";
            this.pBlue.Size = new System.Drawing.Size(32, 32);
            this.pBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBlue.TabIndex = 26;
            this.pBlue.TabStop = false;
            this.pBlue.Click += new System.EventHandler(this.chooseBackground);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(459, 536);
            this.Controls.Add(this.useAutoMove);
            this.Controls.Add(this.pDefault);
            this.Controls.Add(this.noAnswerGame);
            this.Controls.Add(this.noLandScapeObj);
            this.Controls.Add(this.spObj);
            this.Controls.Add(this.timerUse);
            this.Controls.Add(this.endBooster);
            this.Controls.Add(this.rrrObj);
            this.Controls.Add(this.pRed);
            this.Controls.Add(this.pPink);
            this.Controls.Add(this.pGreen);
            this.Controls.Add(this.pBlue);
            this.Controls.Add(this.bg_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encreaseObj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.encreaseObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrrObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown encreaseObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bg_color;
        private System.Windows.Forms.PictureBox pBlue;
        private System.Windows.Forms.PictureBox pGreen;
        private System.Windows.Forms.PictureBox pPink;
        private System.Windows.Forms.PictureBox pRed;
        private System.Windows.Forms.NumericUpDown rrrObj;
        private System.Windows.Forms.CheckBox endBooster;
        private System.Windows.Forms.CheckBox timerUse;
        private System.Windows.Forms.NumericUpDown spObj;
        private System.Windows.Forms.CheckBox noLandScapeObj;
        private System.Windows.Forms.CheckBox noAnswerGame;
        private System.Windows.Forms.PictureBox pDefault;
        private System.Windows.Forms.CheckBox useAutoMove;
    }
}