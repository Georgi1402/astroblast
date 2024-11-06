using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace astroblast
{
    public partial class Form2 : Form
    {
        SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Giogiana\Downloads\mixkit-dense-bomb-impact-2801.wav");
        SoundPlayer _sd = new SoundPlayer(soundLocation: @"C:\Users\Giogiana\Downloads\applause6.wav");
        Int16 x = 500, y = 500, scorOZN = 0, scorAsteroid = 0, level = 2;
        Point pozitieOZN, pozitieAsteroid;
        Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();
            pozitieOZN.Y = 590;
            pozitieAsteroid.X = 550;
            DoubleBuffered = true;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) x -= 10;
            if (x <= 1) x = 1;
            if (e.KeyData == Keys.Right) x += 10;
            if (x >= 1035) x = 1035;
            pozitieOZN.X = x;
            pictureBoxOZN.Invalidate();
            pictureBoxOZN.Location = pozitieOZN;
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

                CheckLevel();
            }


            if (pictureBoxAsteroid.Bounds.IntersectsWith(pictureBoxOZN.Bounds))
            {
                pozitieAsteroid.Y = 1;
                pozitieAsteroid.X = rnd.Next(1, 1125);
                scorOZN++;
                this.Text = "Astroblast    OZN=" + scorOZN + "     Asteroid=" + scorAsteroid + "         Level=" + level;
                CheckLevel();
            }

            pictureBoxAsteroid.Invalidate();
            pictureBoxAsteroid.Location = pozitieAsteroid;
        }
        private bool isGameClosed = false;

        private void CheckLevel()
        {
            if (scorOZN >= 5 && !isGameClosed)
            {
                isGameClosed = true;
                level++;
                this.Text = "Astroblast    OZN=" + scorOZN + "     Asteroid=" + scorAsteroid + "         Level=" + level;
                scorAsteroid = 0;
                scorOZN = 0;

                this.Hide();
                _sd.Stop();
                _soundPlayer.Stop();
                this.Close(); // Închide fereastra curentă
            }
        }


    }
}

