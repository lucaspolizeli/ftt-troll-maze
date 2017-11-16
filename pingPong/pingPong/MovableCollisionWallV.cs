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
    public partial class MovableCollisionWallV : UserControl
    {
        public int MaxY { get; set; }
        public int MinY { get; set; }
        private int ActualY { get; set; }
        private bool MovingUp { get; set; }

        public int Speed { get; set; }

        public MovableCollisionWallV()
        {
            InitializeComponent();

            if (!Program.IsInDesignMode)
            {
                Time.InternalTimer.Tick += InternalTimer_Tick; ;
                CollisionWall.ActiveWalls.Add(this);
            }
        }

        private void InternalTimer_Tick(object sender, EventArgs e)
        {
            if (MovingUp)
            {
                ActualY++;
                this.Top += 1;
            }
            else
            {
                ActualY--;
                this.Top -= 1;
            }

            if (ActualY < MinY)
                MovingUp = true;
            else if (ActualY > MaxY)
                MovingUp = false;
        }
    }
}
