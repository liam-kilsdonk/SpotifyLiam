namespace SpotifyLiam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public static void test()
        {
            Console.Beep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pauze
            test();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //play
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Replay
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //de laad bar
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}