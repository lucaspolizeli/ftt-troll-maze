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
        public Player()
        {
            InitializeComponent();
            Time.InternalTimer.Elapsed += InternalTimer_Elapsed;
        }

        private void InternalTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach(CollisionWall wall in CollisionWall.ActiveWalls)
        }
    }
}
