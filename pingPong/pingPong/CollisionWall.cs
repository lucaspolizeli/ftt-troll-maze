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
    public partial class CollisionWall : UserControl
    {
        public static List<UserControl> ActiveWalls = new List<UserControl>();

        public CollisionWall()
        {
            InitializeComponent();

            if (!Program.IsInDesignMode)
                ActiveWalls.Add(this);
        }
    }
}
