using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace pingPong
{
    public partial class frGame : Form
    {
        bool mustClose = false;
        DateTime tempoInicial;
        public TimeSpan subTimes;

        public frGame()
        {
            Time.Setup();
            InitializeComponent();
            Time.InternalTimer.Tick += InternalTimer_Tick;
        }

        private void InternalTimer_Tick(object sender, EventArgs e)
        {
            if (pbYouWin.Bounds.IntersectsWith(player1.Bounds))
            {
                frEndGame end = new frEndGame();
                DateTime tempoFinal = DateTime.Now;
                subTimes = tempoFinal.Subtract(tempoInicial);
                end.ShowDialog();
                this.Close();
            }
            if (mustClose) this.Close();
        }

        public static void playJohnCena()
        {
            SoundPlayer johncena = new SoundPlayer(@"\src\john-cena-meme-original.wav");
            johncena.Play();
        }
        private void playCJ()
        {
            SoundPlayer CJ = new SoundPlayer(@"\src\john-cena-meme-original.wav");
            CJ.Play();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        public void frGame_Load(object sender, EventArgs e)
        {
            
            tempoInicial = DateTime.Now;
            
        }
    }
}
