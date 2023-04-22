namespace Stay_Alone_интерфейс
{
    partial class FMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainMenu));
            this.PBName = new System.Windows.Forms.PictureBox();
            this.PBPlay = new System.Windows.Forms.PictureBox();
            this.PBExit = new System.Windows.Forms.PictureBox();
            this.PBSettings = new System.Windows.Forms.PictureBox();
            this.PBVolume = new System.Windows.Forms.PictureBox();
            this.PBReg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBReg)).BeginInit();
            this.SuspendLayout();
            // 
            // PBName
            // 
            this.PBName.BackColor = System.Drawing.Color.Transparent;
            this.PBName.Image = ((System.Drawing.Image)(resources.GetObject("PBName.Image")));
            this.PBName.Location = new System.Drawing.Point(52, 18);
            this.PBName.Margin = new System.Windows.Forms.Padding(2);
            this.PBName.Name = "PBName";
            this.PBName.Size = new System.Drawing.Size(161, 151);
            this.PBName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBName.TabIndex = 0;
            this.PBName.TabStop = false;
            // 
            // PBPlay
            // 
            this.PBPlay.BackColor = System.Drawing.Color.Transparent;
            this.PBPlay.Image = ((System.Drawing.Image)(resources.GetObject("PBPlay.Image")));
            this.PBPlay.Location = new System.Drawing.Point(52, 227);
            this.PBPlay.Margin = new System.Windows.Forms.Padding(2);
            this.PBPlay.Name = "PBPlay";
            this.PBPlay.Size = new System.Drawing.Size(73, 49);
            this.PBPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPlay.TabIndex = 1;
            this.PBPlay.TabStop = false;
            // 
            // PBExit
            // 
            this.PBExit.BackColor = System.Drawing.Color.Transparent;
            this.PBExit.Image = ((System.Drawing.Image)(resources.GetObject("PBExit.Image")));
            this.PBExit.Location = new System.Drawing.Point(52, 305);
            this.PBExit.Margin = new System.Windows.Forms.Padding(2);
            this.PBExit.Name = "PBExit";
            this.PBExit.Size = new System.Drawing.Size(73, 48);
            this.PBExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBExit.TabIndex = 2;
            this.PBExit.TabStop = false;
            this.PBExit.Click += new System.EventHandler(this.PBExit_Click);
            // 
            // PBSettings
            // 
            this.PBSettings.BackColor = System.Drawing.Color.Transparent;
            this.PBSettings.Image = ((System.Drawing.Image)(resources.GetObject("PBSettings.Image")));
            this.PBSettings.Location = new System.Drawing.Point(52, 272);
            this.PBSettings.Margin = new System.Windows.Forms.Padding(2);
            this.PBSettings.Name = "PBSettings";
            this.PBSettings.Size = new System.Drawing.Size(105, 44);
            this.PBSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSettings.TabIndex = 3;
            this.PBSettings.TabStop = false;
            this.PBSettings.Click += new System.EventHandler(this.PBSettings_Click);
            // 
            // PBVolume
            // 
            this.PBVolume.BackColor = System.Drawing.Color.Transparent;
            this.PBVolume.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PBVolume.ErrorImage")));
            this.PBVolume.Image = ((System.Drawing.Image)(resources.GetObject("PBVolume.Image")));
            this.PBVolume.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBVolume.InitialImage")));
            this.PBVolume.Location = new System.Drawing.Point(419, 293);
            this.PBVolume.Margin = new System.Windows.Forms.Padding(2);
            this.PBVolume.Name = "PBVolume";
            this.PBVolume.Size = new System.Drawing.Size(154, 59);
            this.PBVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBVolume.TabIndex = 4;
            this.PBVolume.TabStop = false;
            // 
            // PBReg
            // 
            this.PBReg.BackColor = System.Drawing.Color.Transparent;
            this.PBReg.Image = ((System.Drawing.Image)(resources.GetObject("PBReg.Image")));
            this.PBReg.Location = new System.Drawing.Point(447, 293);
            this.PBReg.Margin = new System.Windows.Forms.Padding(0);
            this.PBReg.Name = "PBReg";
            this.PBReg.Size = new System.Drawing.Size(10, 26);
            this.PBReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBReg.TabIndex = 5;
            this.PBReg.TabStop = false;
            this.PBReg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBReg_MouseMove);
            // 
            // FMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 354);
            this.Controls.Add(this.PBReg);
            this.Controls.Add(this.PBVolume);
            this.Controls.Add(this.PBSettings);
            this.Controls.Add(this.PBExit);
            this.Controls.Add(this.PBPlay);
            this.Controls.Add(this.PBName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(616, 393);
            this.Name = "FMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stay Alone";
            this.Load += new System.EventHandler(this.FMainMenu_Load);
            this.Move += new System.EventHandler(this.FMainMenu_Move);
            this.Resize += new System.EventHandler(this.FMainMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBName;
        private System.Windows.Forms.PictureBox PBPlay;
        private System.Windows.Forms.PictureBox PBExit;
        private System.Windows.Forms.PictureBox PBSettings;
        private System.Windows.Forms.PictureBox PBVolume;
        private System.Windows.Forms.PictureBox PBReg;
    }
}

