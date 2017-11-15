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
            Player.Location = PointToClient(Form.MousePosition);
            change = (timeElapsed % 800 == 0);
            if (change) moveWalls();
            if (wallCollision())
            {
                GameRoutine.Stop();
                using (Form form = new Form())
                {
                    Image img = Image.FromFile(@"C:\Users\User\Pictures\N2\maxresdefault.jpg");

                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Size = img.Size;

                    PictureBox pb = new PictureBox();
                    pb.Dock = DockStyle.Fill;
                    pb.Image = img;

                    form.Controls.Add(pb);
                    //playSimpleSound();
                    form.ShowDialog();
                    frGameOver fr = new frGameOver();
                    fr.Pontuacao.Text = "Voce terminou o jogo em "+ timeElapsed/1000 + "segundos !";
                    fr.ShowDialog();
                    this.Close();
                }
            }


        }
        public void moveWalls()
        {
            if (fallingBlock1.Height == 54)
            {
                fallingBlock1.Height = 24;
                fallingBlock2.Height = 54;
                fallingBlock3.Height = 24;
                fallingBlock4.Height = 54;
            }
            else
            {
                fallingBlock1.Height = 54;
                fallingBlock2.Height = 24;
                fallingBlock3.Height = 54;
                fallingBlock4.Height = 24;
            }
        }
        public bool wallCollision()
        {
            if (Player.Bounds.IntersectsWith(fallingBlock1.Bounds) ||
                Player.Bounds.IntersectsWith(fallingBlock2.Bounds) ||
                Player.Bounds.IntersectsWith(fallingBlock3.Bounds) ||
                Player.Bounds.IntersectsWith(fallingBlock4.Bounds))
                return true;
            else return false;
            
        }
    }
}
