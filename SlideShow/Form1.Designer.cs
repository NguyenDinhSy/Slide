namespace SlideShow
{
    partial class SlideShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideShow));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.thum1 = new System.Windows.Forms.PictureBox();
            this.thum2 = new System.Windows.Forms.PictureBox();
            this.thum3 = new System.Windows.Forms.PictureBox();
            this.thum4 = new System.Windows.Forms.PictureBox();
            this.thum5 = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thum4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thum5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.thum1);
            this.flowLayoutPanel1.Controls.Add(this.thum2);
            this.flowLayoutPanel1.Controls.Add(this.thum3);
            this.flowLayoutPanel1.Controls.Add(this.thum4);
            this.flowLayoutPanel1.Controls.Add(this.thum5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(145, 373);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(667, 57);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // thum1
            // 
            this.thum1.Image = ((System.Drawing.Image)(resources.GetObject("thum1.Image")));
            this.thum1.Location = new System.Drawing.Point(3, 3);
            this.thum1.Name = "thum1";
            this.thum1.Size = new System.Drawing.Size(90, 50);
            this.thum1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thum1.TabIndex = 0;
            this.thum1.TabStop = false;
            // 
            // thum2
            // 
            this.thum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thum2.Image = ((System.Drawing.Image)(resources.GetObject("thum2.Image")));
            this.thum2.Location = new System.Drawing.Point(99, 3);
            this.thum2.Name = "thum2";
            this.thum2.Size = new System.Drawing.Size(100, 50);
            this.thum2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thum2.TabIndex = 1;
            this.thum2.TabStop = false;
            // 
            // thum3
            // 
            this.thum3.Image = ((System.Drawing.Image)(resources.GetObject("thum3.Image")));
            this.thum3.Location = new System.Drawing.Point(205, 3);
            this.thum3.Name = "thum3";
            this.thum3.Size = new System.Drawing.Size(100, 50);
            this.thum3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thum3.TabIndex = 2;
            this.thum3.TabStop = false;
            // 
            // thum4
            // 
            this.thum4.Image = ((System.Drawing.Image)(resources.GetObject("thum4.Image")));
            this.thum4.Location = new System.Drawing.Point(311, 3);
            this.thum4.Name = "thum4";
            this.thum4.Size = new System.Drawing.Size(100, 50);
            this.thum4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thum4.TabIndex = 3;
            this.thum4.TabStop = false;
            // 
            // thum5
            // 
            this.thum5.Image = ((System.Drawing.Image)(resources.GetObject("thum5.Image")));
            this.thum5.Location = new System.Drawing.Point(417, 3);
            this.thum5.Name = "thum5";
            this.thum5.Size = new System.Drawing.Size(100, 50);
            this.thum5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thum5.TabIndex = 4;
            this.thum5.TabStop = false;
            // 
            // picShow
            // 
            this.picShow.Image = ((System.Drawing.Image)(resources.GetObject("picShow.Image")));
            this.picShow.Location = new System.Drawing.Point(29, 12);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(840, 354);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 2;
            this.picShow.TabStop = false;
            // 
            // SlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 460);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Name = "SlideShow";
            this.Text = "Slide Show";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thum4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thum5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox thum1;
        private System.Windows.Forms.PictureBox thum2;
        private System.Windows.Forms.PictureBox thum3;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox thum4;
        private System.Windows.Forms.PictureBox thum5;
    }
}

