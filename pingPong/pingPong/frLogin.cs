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
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frGame game = new frGame();
            game.ShowDialog();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            frCadastro cadastro = new frCadastro();
            cadastro.ShowDialog();
        }
    }
}
