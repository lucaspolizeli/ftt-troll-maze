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
                Time.BlinkTimer.Tick += BlinkTimer_Tick;
                CollisionWall.ActiveWalls.Add(this);
            }
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            if (Enabled == true) { Enabled = false; Visible = false; } else { Enabled = true; Visible = true; }
        }
    }
}
