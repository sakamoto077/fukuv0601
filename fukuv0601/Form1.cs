namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        string chr = "(・・)";

        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0) //0より小さい時
            {
                vx = 50;
            }
            if (label1.Top < 0)
            {
                vy = 10;
            }
            if (label1.Right > 805)
            {
                vx = -30;
            }
            if (label1.Top > 438)
            {
                vy = -90;
            }


            string t = label1.Text;
            label1.Text = chr;
            chr = t;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int vx = -10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vx = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "坂本　彬";

        }


    }
}