namespace astroblast
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            pictureBoxOZN = new PictureBox();
            pictureBoxAsteroid = new PictureBox();
            timerAsteroid = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxOZN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAsteroid).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOZN
            // 
            pictureBoxOZN.BackColor = Color.Transparent;
            pictureBoxOZN.Image = Properties.Resources.transparent_ufo_1__1_;
            pictureBoxOZN.Location = new Point(490, 600);
            pictureBoxOZN.Name = "pictureBoxOZN";
            pictureBoxOZN.Size = new Size(125, 62);
            pictureBoxOZN.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOZN.TabIndex = 0;
            pictureBoxOZN.TabStop = false;
            // 
            // pictureBoxAsteroid
            // 
            pictureBoxAsteroid.BackColor = Color.Transparent;
            pictureBoxAsteroid.Image = Properties.Resources.meteordreapa;
            pictureBoxAsteroid.Location = new Point(550, 21);
            pictureBoxAsteroid.Name = "pictureBoxAsteroid";
            pictureBoxAsteroid.Size = new Size(125, 62);
            pictureBoxAsteroid.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAsteroid.TabIndex = 1;
            pictureBoxAsteroid.TabStop = false;
            // 
            // timerAsteroid
            // 
            timerAsteroid.Enabled = true;
            timerAsteroid.Interval = 10;
            timerAsteroid.Tick += timerAsteroid_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.alienplanet;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1157, 670);
            Controls.Add(pictureBoxAsteroid);
            Controls.Add(pictureBoxOZN);
            Name = "Form2";
            Text = "Astrablast";
            KeyDown += Form2_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxOZN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAsteroid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxOZN;
        private PictureBox pictureBoxAsteroid;
        private System.Windows.Forms.Timer timerAsteroid;
    }
}