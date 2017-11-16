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
    public partial class BlinkWall : UserControl
    {
        public BlinkWall()
        {
            InitializeComponent();
            if (!Program.IsInDesignMode)
            {
                Time.InternalTimer.Tick += InternalTimer_Tick;
                CollisionWall.ActiveWalls.Add(this);
            }
        }

        private void InternalTimer_Tick(object sender, EventArgs e)
        {
               /* if (frGame.timeElapsed % 1000 == 0)
                {

                }
                */
        }
    }
}
