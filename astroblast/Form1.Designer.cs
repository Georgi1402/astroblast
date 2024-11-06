namespace astroblast
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            pictureBoxUFO = new PictureBox();
            pictureBoxAsteroid = new PictureBox();
            timerAsteroid = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxUFO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAsteroid).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxUFO
            // 
            pictureBoxUFO.BackColor = Color.Transparent;
            pictureBoxUFO.BackgroundImageLayout = ImageLayout.None;
            pictureBoxUFO.Image = Properties.Resources.ufo;
            pictureBoxUFO.Location = new Point(490, 563);
            pictureBoxUFO.Name = "pictureBoxUFO";
            pictureBoxUFO.Size = new Size(122, 105);
            pictureBoxUFO.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUFO.TabIndex = 0;
            pictureBoxUFO.TabStop = false;
            // 
            // pictureBoxAsteroid
            // 
            pictureBoxAsteroid.BackColor = Color.Transparent;
            pictureBoxAsteroid.Image = Properties.Resources.fire;
            pictureBoxAsteroid.Location = new Point(1015, 600);
            pictureBoxAsteroid.Name = "pictureBoxAsteroid";
            pictureBoxAsteroid.Size = new Size(62, 68);
            pictureBoxAsteroid.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAsteroid.TabIndex = 1;
            pictureBoxAsteroid.TabStop = false;
            // 
            // timerAsteroid
            // 
            timerAsteroid.Enabled = true;
            timerAsteroid.Interval = 20;
            timerAsteroid.Tick += timerAsteroid_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.planet;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1157, 670);
            Controls.Add(pictureBoxAsteroid);
            Controls.Add(pictureBoxUFO);
            Name = "Form1";
            Text = "Astroblast";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxUFO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAsteroid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxUFO;
        private PictureBox pictureBoxAsteroid;
        private System.Windows.Forms.Timer timerAsteroid;
    }
}