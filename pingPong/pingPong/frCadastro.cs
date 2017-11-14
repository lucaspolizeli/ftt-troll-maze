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
    public partial class frCadastro : Form
    {
        public frCadastro()
        {
            InitializeComponent();
        }

        private void btFinalizaCadastro_Click(object sender, EventArgs e)
        {
            string cadastroUsuario = txtNome.Text + "|" + txtUsuario.Text + "|" + txtPassword.Text;
            File.WriteAllText("usuarios.txt", cadastroUsuario);
        }
    }
}
