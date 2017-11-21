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
    public partial class frGameOver : Form
    {
        int tempo = 0;
        public frGameOver()
        {
            InitializeComponent();
            Time.BlinkTimer.Tick += BlinkTimer_Tick;
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            tempo += 1500;
            if (tempo % 4500 <= 0) this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
