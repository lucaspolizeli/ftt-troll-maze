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
    public partial class frMenu : Form
    {
        public frMenu()
        {
            InitializeComponent();
        }

        public void btJogar_Click(object sender, EventArgs e)
        {
            frGame Jogo = new frGame();
            Jogo.ShowDialog();
        }

        private void btRecordes_Click(object sender, EventArgs e)
        {
            frRecordes recordes = new frRecordes();
            recordes.ShowDialog();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            frSobre sobre = new frSobre();
            sobre.ShowDialog();
        }

        private void btHowTo_Click(object sender, EventArgs e)
        {
            var howto = new frComoJogar();
            howto.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
