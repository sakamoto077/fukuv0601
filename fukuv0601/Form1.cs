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
            //MessageBox.Show($"{label1.Bottom}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0) //0より小さい時
            {
                vx = Math.Abs(vx + (vx / 10));
            }
            if (label1.Right > ClientSize.Width) //幅
            {
                vx = -Math.Abs(vx + (vx / 10));
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy + (vy / 10));
            }
            if (label1.Bottom > ClientSize.Height)　//高さ
            {
                vy = -Math.Abs(vy + (vy / 10));
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