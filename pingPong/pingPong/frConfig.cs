using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingPong
{
    public partial class frConfig : Form
    {
        public frConfig()
        {
            InitializeComponent();
            if (frGame.soundEnabled)
            {
                btEna.Enabled = false;
                btDes.Enabled = true;
            }
            else
            {
                btEna.Enabled = true;
                btDes.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEna_Click(object sender, EventArgs e)
        {
            frGame.enableSound();
            btDes.Enabled = true;
            btEna.Enabled = false;
            
        }

        private void btDes_Click(object sender, EventArgs e)
        {
            frGame.disableSound();
            btEna.Enabled = true;
            btDes.Enabled = false;
        }
    }
}
