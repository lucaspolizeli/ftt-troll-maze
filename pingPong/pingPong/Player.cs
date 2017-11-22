using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pingPong
{
    public partial class Player : UserControl
    {
        bool IsFollowingCursor { get; set; }
        public bool Clicked { get; set; }

        public Player()
        {
            InitializeComponent();
            if (!Program.IsInDesignMode) Time.InternalTimer.Tick += InternalTimer_Tick; ;
        }

        public SoundPlayer johncena = new SoundPlayer(pingPong.Properties.Resources.john_cena_meme_original);


        private void InternalTimer_Tick(object sender, EventArgs e)
        {
            foreach (UserControl wall in CollisionWall.ActiveWalls)
            {
                if (this.Bounds.IntersectsWith(wall.Bounds) && wall.Visible == true)
                {
                    Time.InternalTimer.Stop(); Time.BlinkTimer.Stop();
                    Cursor.Show();
                    Cursor.Clip = Rectangle.Empty;
                    johncena.Play();
                    frGameOver over = new frGameOver();
                    over.ShowDialog();
                    johncena.Stop();
                    FindForm().Close();
                    Console.WriteLine(wall.Name);
                    break;
                }
            }
            if (IsFollowingCursor)
                Location = this.FindForm().PointToClient(new Point(Cursor.Position.X - 5, Cursor.Position.Y - 5));
        }

        private void Player_MouseClick(object sender, MouseEventArgs e)
        {
            if (Clicked == false)
            {
                IsFollowingCursor = true;
                Cursor.Hide();
                Cursor.Clip = FindForm().Bounds;
                Clicked = true;
            }

        }
    }
}
