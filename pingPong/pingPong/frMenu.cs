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

        private void btJogar_Click(object sender, EventArgs e)
        {
            frGame Jogo = new frGame();
            Jogo.ShowDialog();
        }

        private void btRecordes_Click(object sender, EventArgs e)
        {
            //frRecords recordes = new frRecords();
            //recordes.ShowDialog();
        }

        private void bt_Click(object sender, EventArgs e)
        {
          //  frAbout sobre = new frAbout();
           // sobre.ShowDialog();
        }
    }
}
