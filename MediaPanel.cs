using System.Media;
using System.Numerics;

namespace SpotifyLiam
{
    public partial class MediaPanel : Form
    {
        private SoundPlayer player;
        public MediaPanel()
        {
            InitializeComponent();
            player = new SoundPlayer("C:/Users/liamg/Music/playlist-spotifyapp/song.wav");
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

        private void btnPause_Click(object sender, EventArgs e)
        {
            //pauze
            //player.Pause();
            player.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //play
            PlaySound("C:/Users/liamg/Music/playlist-spotifyapp/song.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Replay
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