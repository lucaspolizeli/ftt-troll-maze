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
using System.Threading;

namespace pingPong
{
    public partial class frGame : Form
    {
        public int timeElapsed = 0;
        public bool change = false;
        public frGame()
        {
            Time.Setup();
            InitializeComponent();
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\Pictures\N2\john-cena-meme-original.wav");
            simpleSound.Play();
        }

        private void Player_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            //Cursor.Clip = this.Bounds;
            Cursor.Position = new Point(Cursor.Position.X - 5, Cursor.Position.Y - 5);
            GameRoutine.Start();

        }

        private void GameRoutine_Tick(object sender, EventArgs e)
        {
            timeElapsed += 20;
            change = (timeElapsed % 800 == 0);
        }
    }
}
