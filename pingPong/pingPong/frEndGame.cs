using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pingPong
{
    public partial class frEndGame : Form
    {
        public frEndGame()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            var jogo = new frGame();
            string conteudo = txtNomePlayerWin.Text + " || " + jogo.subTimes.ToString() + Environment.NewLine;
            File.WriteAllText("recordes.txt", conteudo);

            this.Close();
            
        }
    }
}
