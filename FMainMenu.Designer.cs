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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TP0_Main = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PBVolume = new System.Windows.Forms.PictureBox();
            this.PBReg = new System.Windows.Forms.PictureBox();
            this.PBPlay = new System.Windows.Forms.PictureBox();
            this.PBSettings = new System.Windows.Forms.PictureBox();
            this.PBExit = new System.Windows.Forms.PictureBox();
            this.PBName = new System.Windows.Forms.PictureBox();
            this.TabControl.SuspendLayout();
            this.TP0_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TP0_Main);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(600, 354);
            this.TabControl.TabIndex = 0;
            // 
            // TP0_Main
            // 
            this.TP0_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TP0_Main.BackgroundImage")));
            this.TP0_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TP0_Main.Controls.Add(this.PBName);
            this.TP0_Main.Controls.Add(this.PBExit);
            this.TP0_Main.Controls.Add(this.PBSettings);
            this.TP0_Main.Controls.Add(this.PBPlay);
            this.TP0_Main.Controls.Add(this.PBReg);
            this.TP0_Main.Controls.Add(this.PBVolume);
            this.TP0_Main.Location = new System.Drawing.Point(4, 22);
            this.TP0_Main.Name = "TP0_Main";
            this.TP0_Main.Size = new System.Drawing.Size(592, 328);
            this.TP0_Main.TabIndex = 0;
            this.TP0_Main.Text = "TP0_Main";
            this.TP0_Main.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PBVolume
            // 
            this.PBVolume.BackColor = System.Drawing.Color.Transparent;
            this.PBVolume.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PBVolume.ErrorImage")));
            this.PBVolume.Image = ((System.Drawing.Image)(resources.GetObject("PBVolume.Image")));
            this.PBVolume.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBVolume.InitialImage")));
            this.PBVolume.Location = new System.Drawing.Point(410, 248);
            this.PBVolume.Margin = new System.Windows.Forms.Padding(2);
            this.PBVolume.Name = "PBVolume";
            this.PBVolume.Size = new System.Drawing.Size(154, 59);
            this.PBVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBVolume.TabIndex = 5;
            this.PBVolume.TabStop = false;
            // 
            // PBReg
            // 
            this.PBReg.BackColor = System.Drawing.Color.Transparent;
            this.PBReg.Image = ((System.Drawing.Image)(resources.GetObject("PBReg.Image")));
            this.PBReg.Location = new System.Drawing.Point(449, 248);
            this.PBReg.Margin = new System.Windows.Forms.Padding(0);
            this.PBReg.Name = "PBReg";
            this.PBReg.Size = new System.Drawing.Size(10, 26);
            this.PBReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBReg.TabIndex = 6;
            this.PBReg.TabStop = false;
            // 
            // PBPlay
            // 
            this.PBPlay.BackColor = System.Drawing.Color.Transparent;
            this.PBPlay.Image = ((System.Drawing.Image)(resources.GetObject("PBPlay.Image")));
            this.PBPlay.Location = new System.Drawing.Point(48, 180);
            this.PBPlay.Margin = new System.Windows.Forms.Padding(2);
            this.PBPlay.Name = "PBPlay";
            this.PBPlay.Size = new System.Drawing.Size(73, 49);
            this.PBPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPlay.TabIndex = 7;
            this.PBPlay.TabStop = false;
            // 
            // PBSettings
            // 
            this.PBSettings.BackColor = System.Drawing.Color.Transparent;
            this.PBSettings.Image = ((System.Drawing.Image)(resources.GetObject("PBSettings.Image")));
            this.PBSettings.Location = new System.Drawing.Point(48, 229);
            this.PBSettings.Margin = new System.Windows.Forms.Padding(2);
            this.PBSettings.Name = "PBSettings";
            this.PBSettings.Size = new System.Drawing.Size(105, 44);
            this.PBSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSettings.TabIndex = 8;
            this.PBSettings.TabStop = false;
            // 
            // PBExit
            // 
            this.PBExit.BackColor = System.Drawing.Color.Transparent;
            this.PBExit.Image = ((System.Drawing.Image)(resources.GetObject("PBExit.Image")));
            this.PBExit.Location = new System.Drawing.Point(48, 265);
            this.PBExit.Margin = new System.Windows.Forms.Padding(2);
            this.PBExit.Name = "PBExit";
            this.PBExit.Size = new System.Drawing.Size(73, 48);
            this.PBExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBExit.TabIndex = 9;
            this.PBExit.TabStop = false;
            // 
            // PBName
            // 
            this.PBName.BackColor = System.Drawing.Color.Transparent;
            this.PBName.Image = ((System.Drawing.Image)(resources.GetObject("PBName.Image")));
            this.PBName.Location = new System.Drawing.Point(48, 18);
            this.PBName.Margin = new System.Windows.Forms.Padding(2);
            this.PBName.Name = "PBName";
            this.PBName.Size = new System.Drawing.Size(161, 151);
            this.PBName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBName.TabIndex = 10;
            this.PBName.TabStop = false;
            // 
            // FMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 354);
            this.Controls.Add(this.TabControl);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(616, 393);
            this.Name = "FMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stay Alone";
            this.Load += new System.EventHandler(this.FMainMenu_Load);
            this.Move += new System.EventHandler(this.FMainMenu_Move);
            this.Resize += new System.EventHandler(this.FMainMenu_Resize);
            this.TabControl.ResumeLayout(false);
            this.TP0_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TP0_Main;
        private System.Windows.Forms.PictureBox PBName;
        private System.Windows.Forms.PictureBox PBExit;
        private System.Windows.Forms.PictureBox PBSettings;
        private System.Windows.Forms.PictureBox PBPlay;
        private System.Windows.Forms.PictureBox PBReg;
        private System.Windows.Forms.PictureBox PBVolume;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

