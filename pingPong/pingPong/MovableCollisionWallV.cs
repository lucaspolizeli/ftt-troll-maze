using System.Windows.Forms;

namespace pingPong
{
    public partial class MovableCollisionWallV : CollisionWall
    {
        public int MaxY { get; set; }
        public int MinY { get; set; }
        private int ActualY { get; set; }
        private bool MovingUp { get; set; }

        public MovableCollisionWallV()
        {
            InitializeComponent();

            if (!Program.IsInDesignMode)
                Time.InternalTimer.Elapsed += InternalTimer_Elapsed;
        }

        private void InternalTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (MovingUp)
                {
                    ActualY++;
                    this.Top += 1;
                }
                else
                {
                    ActualY--;
                    this.Top -= 1;
                }

                if (ActualY < MinY)
                    MovingUp = true;
                else if (ActualY > MaxY)
                    MovingUp = false;
            });
        }
    }
}
