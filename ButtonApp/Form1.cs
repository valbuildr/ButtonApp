namespace ButtonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        bool done = false;

        private void label1_Click(object sender, EventArgs e)
        {
            if (!done)
            {
                label1.Text = "the button not the text, dummy!";
                wait(1500);
                label1.Text = "click the button!!!!!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "thanmk";
            done = true;
            wait(1000);
            System.Windows.Forms.Application.Exit();
        }
    }
}
