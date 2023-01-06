namespace FSMRover
{
    partial class MainWindow
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
	        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
	        this.roverPictureBox = new System.Windows.Forms.PictureBox();
	        this.chargeCounter = new System.Windows.Forms.Label();
	        this.chargeIcon = new System.Windows.Forms.PictureBox();
	        this.memoryIcon = new System.Windows.Forms.PictureBox();
	        this.memoryCounter = new System.Windows.Forms.Label();
	        this.storageButton = new System.Windows.Forms.PictureBox();
	        this.storageCounter = new System.Windows.Forms.Label();
	        this.startButton = new System.Windows.Forms.Button();
	        ((System.ComponentModel.ISupportInitialize)(this.roverPictureBox)).BeginInit();
	        ((System.ComponentModel.ISupportInitialize)(this.chargeIcon)).BeginInit();
	        ((System.ComponentModel.ISupportInitialize)(this.memoryIcon)).BeginInit();
	        ((System.ComponentModel.ISupportInitialize)(this.storageButton)).BeginInit();
	        this.SuspendLayout();
	        // 
	        // roverPictureBox
	        // 
	        this.roverPictureBox.BackColor = System.Drawing.Color.Transparent;
	        this.roverPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	        this.roverPictureBox.Image = global::FSMRover.Properties.Resources.DefaultRover;
	        this.roverPictureBox.Location = new System.Drawing.Point(163, 144);
	        this.roverPictureBox.Name = "roverPictureBox";
	        this.roverPictureBox.Size = new System.Drawing.Size(82, 78);
	        this.roverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
	        this.roverPictureBox.TabIndex = 2;
	        this.roverPictureBox.TabStop = false;
	        // 
	        // chargeCounter
	        // 
	        this.chargeCounter.BackColor = System.Drawing.Color.Transparent;
	        this.chargeCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	        this.chargeCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
	        this.chargeCounter.Location = new System.Drawing.Point(710, 16);
	        this.chargeCounter.Name = "chargeCounter";
	        this.chargeCounter.Size = new System.Drawing.Size(30, 30);
	        this.chargeCounter.TabIndex = 3;
	        this.chargeCounter.Text = "10";
	        // 
	        // chargeIcon
	        // 
	        this.chargeIcon.BackColor = System.Drawing.Color.Transparent;
	        this.chargeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chargeIcon.BackgroundImage")));
	        this.chargeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	        this.chargeIcon.Location = new System.Drawing.Point(673, 12);
	        this.chargeIcon.Name = "chargeIcon";
	        this.chargeIcon.Size = new System.Drawing.Size(30, 30);
	        this.chargeIcon.TabIndex = 7;
	        this.chargeIcon.TabStop = false;
	        // 
	        // memoryIcon
	        // 
	        this.memoryIcon.BackColor = System.Drawing.Color.Transparent;
	        this.memoryIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memoryIcon.BackgroundImage")));
	        this.memoryIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	        this.memoryIcon.Location = new System.Drawing.Point(750, 12);
	        this.memoryIcon.Name = "memoryIcon";
	        this.memoryIcon.Size = new System.Drawing.Size(30, 30);
	        this.memoryIcon.TabIndex = 8;
	        this.memoryIcon.TabStop = false;
	        // 
	        // memoryCounter
	        // 
	        this.memoryCounter.BackColor = System.Drawing.Color.Transparent;
	        this.memoryCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	        this.memoryCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
	        this.memoryCounter.Location = new System.Drawing.Point(786, 16);
	        this.memoryCounter.Name = "memoryCounter";
	        this.memoryCounter.Size = new System.Drawing.Size(30, 30);
	        this.memoryCounter.TabIndex = 9;
	        this.memoryCounter.Text = "1";
	        // 
	        // storageButton
	        // 
	        this.storageButton.BackColor = System.Drawing.Color.Transparent;
	        this.storageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("storageButton.BackgroundImage")));
	        this.storageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	        this.storageButton.Location = new System.Drawing.Point(822, 12);
	        this.storageButton.Name = "storageButton";
	        this.storageButton.Size = new System.Drawing.Size(30, 30);
	        this.storageButton.TabIndex = 10;
	        this.storageButton.TabStop = false;
	        // 
	        // storageCounter
	        // 
	        this.storageCounter.BackColor = System.Drawing.Color.Transparent;
	        this.storageCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	        this.storageCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
	        this.storageCounter.Location = new System.Drawing.Point(858, 16);
	        this.storageCounter.Name = "storageCounter";
	        this.storageCounter.Size = new System.Drawing.Size(30, 30);
	        this.storageCounter.TabIndex = 11;
	        this.storageCounter.Text = "1";
	        // 
	        // startButton
	        // 
	        this.startButton.BackColor = System.Drawing.Color.Firebrick;
	        this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	        this.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
	        this.startButton.Location = new System.Drawing.Point(12, 496);
	        this.startButton.Name = "startButton";
	        this.startButton.Size = new System.Drawing.Size(152, 46);
	        this.startButton.TabIndex = 12;
	        this.startButton.Text = "Старт";
	        this.startButton.UseVisualStyleBackColor = false;
	        this.startButton.Click += new System.EventHandler(this.StartButtonClicked);
	        // 
	        // MainWindow
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.BackColor = System.Drawing.Color.DimGray;
	        this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
	        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	        this.ClientSize = new System.Drawing.Size(900, 554);
	        this.Controls.Add(this.startButton);
	        this.Controls.Add(this.storageCounter);
	        this.Controls.Add(this.storageButton);
	        this.Controls.Add(this.memoryCounter);
	        this.Controls.Add(this.memoryIcon);
	        this.Controls.Add(this.chargeCounter);
	        this.Controls.Add(this.chargeIcon);
	        this.Controls.Add(this.roverPictureBox);
	        this.DoubleBuffered = true;
	        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
	        this.Location = new System.Drawing.Point(15, 15);
	        this.Name = "MainWindow";
	        ((System.ComponentModel.ISupportInitialize)(this.roverPictureBox)).EndInit();
	        ((System.ComponentModel.ISupportInitialize)(this.chargeIcon)).EndInit();
	        ((System.ComponentModel.ISupportInitialize)(this.memoryIcon)).EndInit();
	        ((System.ComponentModel.ISupportInitialize)(this.storageButton)).EndInit();
	        this.ResumeLayout(false);
        }

		#endregion

		private System.Windows.Forms.PictureBox roverPictureBox;
		private System.Windows.Forms.Label chargeCounter;
		private System.Windows.Forms.PictureBox chargeIcon;
		private System.Windows.Forms.PictureBox memoryIcon;
		private System.Windows.Forms.Label memoryCounter;
		private System.Windows.Forms.PictureBox storageButton;
		private System.Windows.Forms.Label storageCounter;
		private System.Windows.Forms.Button startButton;
	}
}