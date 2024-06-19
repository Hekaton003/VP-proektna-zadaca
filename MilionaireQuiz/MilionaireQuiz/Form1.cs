using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MilionaireQuiz
{
    public partial class Form1 : Form
    {
        public Game game;
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        public Form1()
        {
           
            InitializeComponent();
            game = new Game();
        }
        private void PlaySound(string soundFile)
        {
            try
            {
                if (waveOut != null)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                    waveOut = null;
                }

                waveOut = new WaveOutEvent();
                audioFileReader = new AudioFileReader(soundFile);
                waveOut.Init(audioFileReader);
                waveOut.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(game);
            if (form3.ShowDialog() == DialogResult.OK)
            {
                MainForm form = new MainForm(game);
                form.FormClosed += (s, args) => this.Close();
                form.Show();
                this.Hide();
                waveOut.Stop();
                waveOut.Dispose(); 
            }
            
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Milionaire.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            PlaySound("Intro.mp3");
        }
    }
}
