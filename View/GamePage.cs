using System.Timers;

namespace CatchMeGame
{
    public partial class GamePage : Form
    {
        System.Timers.Timer timer;
        int s;
        int clicks = 0;
        public static string afterMessage = "";
        public static string scoreMessage = "";
        public GamePage()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            timer.Start();
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s++;
                if (s == 60)
                {
                    s = 0;
                    timer.Stop();
                    string text = "You Lost";
                    afterMessage = text;
                    scoreMessage = label1.Text;
                    new EndPage().ShowDialog();
                    Close();
                    
                }
                label2.Text = string.Format("Time: {0}", s.ToString().PadLeft(2, '0'));
            }));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
            label1.Text = string.Format("Score: {0}", clicks);
            if (clicks == 5)
            {
                timer.Stop();
                string text = "You won!!!";
                afterMessage = text;
                scoreMessage = label1.Text;
                new EndPage().ShowDialog();
                Close();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - button1.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - button1.ClientSize.Height;
            this.button1.Location = new Point(rand.Next(maxWidth), rand.Next(maxHeight));

        }


    }
}
