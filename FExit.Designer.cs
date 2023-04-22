namespace Stay_Alone_интерфейс
{
    partial class FExit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FExit));
            this.PBYes = new System.Windows.Forms.PictureBox();
            this.PBNo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNo)).BeginInit();
            this.SuspendLayout();
            // 
            // PBYes
            // 
            this.PBYes.BackColor = System.Drawing.Color.Transparent;
            this.PBYes.Image = ((System.Drawing.Image)(resources.GetObject("PBYes.Image")));
            this.PBYes.Location = new System.Drawing.Point(76, 86);
            this.PBYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBYes.Name = "PBYes";
            this.PBYes.Size = new System.Drawing.Size(54, 54);
            this.PBYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBYes.TabIndex = 0;
            this.PBYes.TabStop = false;
            this.PBYes.Click += new System.EventHandler(this.PBYes_Click);
            // 
            // PBNo
            // 
            this.PBNo.BackColor = System.Drawing.Color.Transparent;
            this.PBNo.Image = ((System.Drawing.Image)(resources.GetObject("PBNo.Image")));
            this.PBNo.Location = new System.Drawing.Point(182, 86);
            this.PBNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBNo.Name = "PBNo";
            this.PBNo.Size = new System.Drawing.Size(54, 54);
            this.PBNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBNo.TabIndex = 1;
            this.PBNo.TabStop = false;
            this.PBNo.Click += new System.EventHandler(this.PBNo_Click);
            // 
            // FExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 188);
            this.Controls.Add(this.PBNo);
            this.Controls.Add(this.PBYes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FExit";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FExit";
            this.Activated += new System.EventHandler(this.FExit_Activated);
            this.Load += new System.EventHandler(this.FExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBYes;
        private System.Windows.Forms.PictureBox PBNo;
    }
}