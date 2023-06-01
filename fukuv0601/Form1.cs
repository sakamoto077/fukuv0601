namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Left = -10;
            int vx = -10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left = 10;
            int vx = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {
               timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}