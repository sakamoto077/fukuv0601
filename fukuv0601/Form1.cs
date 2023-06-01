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
            int vx = -10;
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            int vx = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {
               timer1.Stop();
            label1.Text="ç‚ñ{Å@ïj";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += 10;
            button2.Left -= 10;
        }
    }
}