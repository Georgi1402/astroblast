using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace astroblast
{
    public partial class Form1 : Form
    {
        SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Giogiana\Downloads\mixkit-dense-bomb-impact-2801.wav");
        SoundPlayer _sd = new SoundPlayer(soundLocation: @"C:\Users\Giogiana\Downloads\applause6.wav");
        Int16 x = 500, y = 500, scorOZN = 0, scorAsteroid = 0, level = 1;
        Point pozitieOZN, pozitieAsteroid;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            pozitieOZN.Y = 590;
            pozitieAsteroid.X = 550;
            DoubleBuffered = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) x -= 10;
            if (x <= 1) x = 1;
            if (e.KeyData == Keys.Right) x += 10;
            if (x >= 1035) x = 1035;
            pozitieOZN.X = x;
            pictureBoxUFO.Invalidate();
            pictureBoxUFO.Location = pozitieOZN;
        }
        private void timerAsteroid_Tick(object sender, EventArgs e)
        {
            pozitieAsteroid.Y += 5;
            if (pozitieAsteroid.Y >= 600)
            {
                pozitieAsteroid.Y = 1;
                pozitieAsteroid.X = rnd.Next(1, 1125);
                scorAsteroid++;
                this.Text = "Astroblast    OZN=" + scorOZN + "     Asteroid=" + scorAsteroid + "         Level=" + level;
                _soundPlayer.Play();

                CheckLevel();  // Check the level condition
            }

            if (pictureBoxAsteroid.Bounds.IntersectsWith(pictureBoxUFO.Bounds))
            {
                pozitieAsteroid.Y = 1;
                pozitieAsteroid.X = rnd.Next(1, 1125);
                scorOZN++;
                this.Text = "Astroblast    OZN=" + scorOZN + "     Asteroid=" + scorAsteroid + "         Level=" + level;
                _sd.Play();

                CheckLevel();  // Check the level condition
            }

            pictureBoxAsteroid.Invalidate();
            pictureBoxAsteroid.Location = pozitieAsteroid;
        }

        private void CheckLevel()
        {
            if (scorOZN >= 5)
            {
                level++;
                this.Text = "Astroblast    OZN=" + scorOZN + "     Asteroid=" + scorAsteroid + "         Level=" + level;
                scorAsteroid = 0;
                scorOZN = 0;
                Form2 newlevel = new Form2();
                this.Hide();
                _sd.Stop();
                _soundPlayer.Stop();
                newlevel.Show();
            }
        }

        
    }
}

