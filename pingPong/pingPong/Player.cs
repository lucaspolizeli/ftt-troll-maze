using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingPong
{
    public partial class Player : UserControl
    {
        bool IsFollowingCursor { get; set; }
        bool clicked { get; set; }

        public Player()
        {
            InitializeComponent();
            if(!Program.IsInDesignMode) Time.InternalTimer.Tick += InternalTimer_Tick; ;
        }

        private void InternalTimer_Tick(object sender, EventArgs e)
        {
            foreach (UserControl wall in CollisionWall.ActiveWalls) {
                if (this.Bounds.IntersectsWith(wall.Bounds) && wall.Visible == true)
                {
                    Time.InternalTimer.Stop(); Time.BlinkTimer.Stop();
                    Cursor.Show();
                    Cursor.Clip = Rectangle.Empty;
                    frGameOver over = new frGameOver();
                    //frGame.playJohnCena();
                    over.ShowDialog();
                    FindForm().Close();                    
                    Console.WriteLine(wall.Name);
                    
                }
                }

            if (IsFollowingCursor)
                Location = this.FindForm().PointToClient(new Point(Cursor.Position.X -5, Cursor.Position.Y -5));
        }

        private void Player_MouseClick(object sender, MouseEventArgs e)
        {
            if(clicked == false)
            {
                IsFollowingCursor = true;
                Cursor.Hide();
                Cursor.Clip = FindForm().Bounds;
                clicked = true;
            }

        }
    }
}
