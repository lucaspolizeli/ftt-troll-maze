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

        public Player()
        {
            InitializeComponent();
            if(!Program.IsInDesignMode) Time.InternalTimer.Tick += InternalTimer_Tick; ;
        }

        private void InternalTimer_Tick(object sender, EventArgs e)
        {
            foreach (UserControl wall in CollisionWall.ActiveWalls) { if (this.Bounds.IntersectsWith(wall.Bounds)) Console.WriteLine("Se fodeu"); }

            if (IsFollowingCursor)
                Location = Program.Game.PointToClient(Cursor.Position);
        }

        private void Player_MouseClick(object sender, MouseEventArgs e)
        {
            IsFollowingCursor = true;
        }
    }
}
