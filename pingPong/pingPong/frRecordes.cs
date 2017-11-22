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
    public partial class frRecordes : Form
    {
        public frRecordes()
        {
            InitializeComponent();
        }

        private void frRecordes_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> recordes = new Dictionary<string, string>();
            string[] conteudo = File.ReadAllLines("recordes.txt");
            for (int i = 0; i < conteudo.Length; i++)
            {
                //lboxRecordes.Items.Add(conteudo[i]);
                string[] dados = conteudo[i].Split('|');
                recordes.Add(dados[1], dados[2]);
            }
        }
    }
}
