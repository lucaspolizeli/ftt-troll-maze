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
        public struct Pontuacao
        {
            public string Nome;
            public string Tempo;
        }
        public frRecordes()
        {
            InitializeComponent();
        }

        private void frRecordes_Load(object sender, EventArgs e)
        {
            List<Pontuacao> recordes = new List<Pontuacao>();
            List<Pontuacao> recordesOrdenados = new List<Pontuacao>();
            string[] conteudo = File.ReadAllLines("recordes.txt");
            Pontuacao pont;
            for (int i = 0; i < conteudo.Length; i++)
            {
                pont = new Pontuacao();
                string[] dados = conteudo[i].Split('|');
                pont.Nome = dados[0]; pont.Tempo =  dados[1];
                recordes.Add(pont);
            }
            recordesOrdenados = recordes.OrderBy(Pontuacao => Pontuacao.Tempo).ToList();
            // To pensando em limitar esse foreach, fazer virar um for que mostre só tipo, os 10 primeiros registros, é só trocar o foreach por um for que vai até 10
            foreach(Pontuacao p in recordesOrdenados) lboxRecordes.Items.Add(p.Nome +"  -------  "+ p.Tempo);
        }
    }
}
