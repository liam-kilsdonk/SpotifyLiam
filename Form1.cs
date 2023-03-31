using System.Media;
using System.Numerics;

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

        private void PlaySound(string soundFilePath)
        {
            SoundPlayer player = new SoundPlayer(soundFilePath);
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pauze
            //player.Pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //play
            test();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Replay
            PlaySound("C:/Users/liamg/Music/playlist c#/minecraft.wav");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //de laad bar yes
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //picture box
        }
    }
}