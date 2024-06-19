using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MilionaireQuiz
{
    public partial class MainForm : Form
    {
        public Game game { get; set; }
        public WaveOutEvent waveOut;
        public AudioFileReader audioFileReader;
        public bool isStarted = false;
        private int timeLeft = 360;
        private bool isSelected = false;
        private bool Quit = false;
        private string option;
        public Random random = new Random();
        public MainForm(Game game)
        {
            this.game =game;
            Game.loadQuestions();
            InitializeComponent();
            timer1 = new Timer();
            label32.Text = "6:00";
            
            timer1.Interval = 1000;
            panel13.Visible = false;
            timer1.Tick += new EventHandler(tick_tack);
            guna2PictureBox1.Enabled = false;
            guna2PictureBox2.Enabled = false;
            guna2PictureBox3.Enabled = false;
            guna2GradientPanel1.BackgroundImage = System.Drawing.Image.FromFile("Clarkson_ITV.jpg");
            guna2PictureBox3.Image = System.Drawing.Image.FromFile("frienf.png");
            guna2PictureBox2.Image = System.Drawing.Image.FromFile("aud.png");
            guna2PictureBox1.Image = System.Drawing.Image.FromFile("50.png");
            guna2Button1.Enabled = false;
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
        private void tick_tack(object sennder, EventArgs args)
        {
            if (timeLeft > 0)
            {
       
                timeLeft--;
                int min = timeLeft / 60;
                int sec = timeLeft % 60;
                string secund = sec.ToString();
                if (sec < 10)
                {
                    secund = "0" + sec.ToString();
                }
                label32.Text = $"{min}:{secund}";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Game over!!!");
                this.Close();
            }
        }
        private void GameOver()
        {
            if (!Quit)
            {
                Form4 form4 = new Form4(game);
                if (form4.ShowDialog() == DialogResult.OK)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                    waveOut = null;
                    timer1.Stop();
                    Form1 form = new Form1();
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                    this.Hide();

                }
            }
            else
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
                timer1.Stop();
                Form1 form = new Form1();
                form.FormClosed += (s, args) => this.Close();
                form.Show();
                this.Hide();
            }
            
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
          
            panel14.Visible = false;
            this.BackgroundImage= System.Drawing.Image.FromFile("Milionaire.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            PlaySound("Start.mp3");
        }
        private void loadQuestion(int index)
        {
            mainTitle.Text = game.CurrentQuestions[index].TheQuestion;
            OptionA.Text = "A:" + game.CurrentQuestions[index].Answers[0];
            OptionB.Text = "B:"+game.CurrentQuestions[index].Answers[1];
            OptionC.Text = "C:"+game.CurrentQuestions[index].Answers[2];
            OptionD.Text = "D:"+game.CurrentQuestions[index].Answers[3];

        }
        private void ResetOptions()
        {
            OptionA.FillColor = Color.SlateGray;
            OptionA.FillColor2 = Color.SlateGray;
            OptionB.FillColor = Color.SlateGray;
            OptionB.FillColor2 = Color.SlateGray;
            OptionC.FillColor = Color.SlateGray;
            OptionC.FillColor2 = Color.SlateGray;
            OptionD.FillColor = Color.SlateGray;
            OptionD.FillColor2 = Color.SlateGray;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ResetOptions();
            if (panel14.Visible == true)
            {
                panel14.Visible = false;
            }
            if(panel13.Visible == true)
            {
                panel13.Visible = false;
            }
       
            if (!isStarted)
            {
                timer1.Start();
                if (game.Category == "Sport")
                {
                    game.loadAllQuestions("Sport"); 
                }
                else if (game.Category == "Technology")
                {
                    game.loadAllQuestions("Technology");
                }
                else if (game.Category == "Music")
                {
                    game.loadAllQuestions("Music");
                }
                else
                {
                    game.loadAllQuestions("Geography");
                }
                loadQuestion(0);
                game.CurrentQuestionIndex = 0;
                isStarted = true;
                guna2PictureBox1.Enabled = true;
                guna2PictureBox2.Enabled = true;
                guna2PictureBox3.Enabled = true;
            }
            else
            {
                if (MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (game.CurrentQuestionIndex < 11)
                    {
                        game.CurrentQuestionIndex++;
                        loadQuestion(game.CurrentQuestionIndex);
                     
                    }     
                }
                else
                {
                    GameOver();
                }
            }
            guna2Button1.Enabled = false;

        }
        private void ChangeColor(int index)
        {
            switch (index)
            {
                case 1:
                    panel1.BackColor = Color.DarkOrange;
                    label33.Text = "500$";
                    game.Money = 500;
                    break;
                case 2:
                    panel2.BackColor = Color.DarkOrange;
                    label33.Text = "1000$";
                    game.Money = 1000;
                    break;
                case 3:
                    panel3.BackColor = Color.DarkOrange;
                    label33.Text = "3000$";
                    game.Money = 3000;
                    break ;
                case 4:
                    panel4.BackColor = Color.DarkOrange;
                    label33.Text = "5000$";
                    game.Money = 5000;
                    break;
                case 5:
                    panel5.BackColor = Color.DarkOrange;
                    label33.Text = "8000$";
                    game.Money = 8000;
                    break;
                case 6:
                    panel6.BackColor = Color.DarkOrange;
                    label33.Text = "14000$";
                    game.Money = 14000;
                    break;
                case 7:
                    panel7.BackColor = Color.DarkOrange;
                    label33.Text = "30000$";
                    game.Money = 30000;
                    break;
                case 8:
                    panel8.BackColor = Color.DarkOrange;
                    label33.Text = "58000$";
                    game.Money = 58000;
                    break;
                case 9:
                    panel9.BackColor = Color.DarkOrange;
                    label33.Text = "86000$";
                    game.Money = 86000;
                    break;
                case 10:
                    panel10.BackColor = Color.DarkOrange;
                    label33.Text = "125000$";
                    game.Money = 125000;
                    break;
                case 11:
                    panel11.BackColor = Color.DarkOrange;
                    label33.Text = "500000$";
                    game.Money = 500000;
                    break;
            }
        }
        private void OptionA_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                game.Category = "Sport";
                isSelected = !isSelected;
                if (isSelected)
                {
                    ResetColor();
                    OptionA.FillColor = Color.Purple;
                    OptionA.FillColor2 = Color.Purple;
                    option = "A";
                    isSelected = false;
                }
                if (game.Category != null)
                {
                    guna2Button1.Enabled = true;
                }

            }
            else
            {
                if(MessageBox.Show("Are you certain?","Confirm your answer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    guna2Button1.Enabled = true;
                    if (game.CheckAnswer("A"))
                    {
                    
                        PlaySound("correct-answer.mp3");
                        OptionA.FillColor = Color.Green;
                        OptionA.FillColor2 = Color.Green;
                        ChangeColor(game.CurrentQuestionIndex+1);
                        if (MessageBox.Show("Correct!!!","Correct Answer", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            PlaySound("Start.mp3");
                        }
                        if (game.CurrentQuestionIndex == 11)
                        {
                            panel12.BackColor = Color.DarkOrange;
                            label33.Text = "1000000$";
                            PlaySound("win-millioner.mp3");
                            game.Money = 1000000;
                            timer1.Stop();
                            MessageBox.Show("Congratulations! You have answered all questions correctly and won the game!");
                            GameOver();
                        }

                    }
                    else
                    {
                        if (game.CurrentQuestionIndex == 11)
                        {
                            PlaySound("lose-millioner.mp3");
                        }
                        else
                        {
                            PlaySound("wrong-answer.mp3");
                        }
                
                        OptionA.FillColor = Color.Red;
                        OptionA.FillColor2 = Color.Red;
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                
            }
        }
        private void OptionB_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                game.Category = "Music";
                isSelected = !isSelected;
                if (isSelected)
                {
                    ResetColor();
                    OptionB.FillColor = Color.Purple;
                    OptionB.FillColor2 = Color.Purple;
                    option = "B";
                    isSelected = false;
                }
                if (game.Category != null)
                {
                    guna2Button1.Enabled = true;
                }
            }
            else
            {
                if (MessageBox.Show("Are you certain?", "Confirm your answer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    guna2Button1.Enabled = true;
                    if (game.CheckAnswer("B"))
                    {
                        ChangeColor(game.CurrentQuestionIndex+1);
                        PlaySound("correct-answer.mp3");
                        OptionB.FillColor = Color.Green;
                        OptionB.FillColor2 = Color.Green;
                        if (MessageBox.Show("Correct!!!", "Correct Answer", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            PlaySound("Start.mp3");
                        }
                        
                        if (game.CurrentQuestionIndex == 11)
                        {
                            panel12.BackColor = Color.DarkOrange;
                            label33.Text = "1000000$";
                            game.Money = 1000000;
                            timer1.Stop();
                            MessageBox.Show("Congratulations! You have answered all questions correctly and won the game!");
                           
                            GameOver();
                        }
                    }
                    else
                    {
                        if (game.CurrentQuestionIndex == 11)
                        {
                            PlaySound("lose-millioner.mp3");
                        }
                        else
                        {
                            PlaySound("wrong-answer.mp3");
                        }

                        OptionB.FillColor = Color.Red;
                        OptionB.FillColor2 = Color.Red;
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                    
            }
        }

        private void OptionC_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                game.Category = "Technology";
                isSelected = !isSelected;
                if (isSelected)
                {
                    ResetColor();
                    OptionC.FillColor = Color.Purple;
                    OptionC.FillColor2 = Color.Purple;
                    option = "C";
                    isSelected = false;
                }
                if (game.Category != null)
                {
                    guna2Button1.Enabled = true;
                }
            }
            else
            {
                if (MessageBox.Show("Are you certain?", "Confirm your answer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    guna2Button1.Enabled = true;
                    if (game.CheckAnswer("C"))
                    {
                        PlaySound("correct-answer.mp3");
                        OptionC.FillColor = Color.Green;
                        OptionC.FillColor2 = Color.Green;
                        ChangeColor(game.CurrentQuestionIndex + 1);
                        if (MessageBox.Show("Correct!!!", "Correct Answer", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            PlaySound("Start.mp3");
                        }
                  
                        if (game.CurrentQuestionIndex == 11)
                        {
                            panel12.BackColor = Color.DarkOrange;
                            label33.Text = "1000000$";
                            game.Money = 1000000;
                            timer1.Stop();
                            MessageBox.Show("Congratulations! You have answered all questions correctly and won the game!");
                           
                            GameOver();
                        }

                    }
                    else
                    {
                        if (game.CurrentQuestionIndex == 11)
                        {
                            PlaySound("lose-millioner.mp3");
                        }
                        else
                        {
                            PlaySound("wrong-answer.mp3");
                        }

                        OptionC.FillColor = Color.Red;
                        OptionC.FillColor2 = Color.Red;
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
            }
            
        }
        private void ResetColor()
        {
           if(option != null)
            {
                switch (option)
                {
                    case "A":
                        OptionA.FillColor = Color.SlateGray;
                        OptionA.FillColor2 = Color.SlateGray;
                        break;

                    case "B":
                        OptionB.FillColor = Color.SlateGray;
                        OptionB.FillColor2 = Color.SlateGray;
                        break;
                    case "C":
                        OptionC.FillColor = Color.SlateGray;
                        OptionC.FillColor2 = Color.SlateGray;
                        break;
                    case "D":
                        OptionD.FillColor = Color.SlateGray;
                        OptionD.FillColor2 = Color.SlateGray;
                        break;

                }
            }
        }
        private void OptionD_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                game.Category = "Geography";
                isSelected = !isSelected;
                if (isSelected)
                {
                    ResetColor();
                    OptionD.FillColor = Color.Purple;
                    OptionD.FillColor2 = Color.Purple;
                    option = "D";
                    isSelected = false;
                }
                if (game.Category != null)
                {
                    guna2Button1.Enabled = true;
                }
            }
            else
            {
                if (MessageBox.Show("Are you certain?", "Confirm your answer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    guna2Button1.Enabled = true;
                    if (game.CheckAnswer("D"))
                    {
                        PlaySound("correct-answer.mp3");
                        OptionD.FillColor = Color.Green;
                        OptionD.FillColor2 = Color.Green;
                        ChangeColor(game.CurrentQuestionIndex + 1);
                        if (MessageBox.Show("Correct!!!", "Correct Answer", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            PlaySound("Start.mp3");
                        }
                    
                        if (game.CurrentQuestionIndex == 11)
                        {
                            panel12.BackColor = Color.DarkOrange;
                            label33.Text = "1000000$";
                            game.Money = 1000000;
                            timer1.Stop();
                            MessageBox.Show("Congratulations! You have answered all questions correctly and won the game!");
                           
                            GameOver();
                        }

                    }
                    else
                    {
                        if (game.CurrentQuestionIndex == 11)
                        {
                            PlaySound("lose-millioner.mp3");
                        }
                        else
                        {
                            PlaySound("wrong-answer.mp3");
                        }

                        OptionD.FillColor = Color.Red;
                        OptionD.FillColor2 = Color.Red;
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }     
            }
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            GeneratePatterns();
            guna2Button4.Enabled = false;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            panel13.Visible = true;
            guna2PictureBox3.Image = System.Drawing.Image.FromFile("FriendC.png");
            guna2PictureBox3.Enabled = false;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            panel14.Visible = true;
            guna2PictureBox2.Image = System.Drawing.Image.FromFile("AudC.png");
            guna2PictureBox2.Enabled = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            char lett1 =GenerateLetter();
            char lett2;
            do
            {
                lett2 = GenerateLetter();
            }while ( lett1 == lett2 );
            CloseOption(lett1);
            CloseOption(lett2);
            guna2PictureBox1.Image = System.Drawing.Image.FromFile("50C.png");
            guna2PictureBox1.Enabled = false;
        }
        private char GenerateLetter()
        {
            char l = (char)random.Next('A', 'D' + 1);
            do
            {
              l= (char)random.Next('A', 'D' + 1);
                 
            }while (game.CheckAnswer(l.ToString())==true);
            
            return l;
        }
        private void CloseOption(char flag)
        {
            switch(flag)
            {
                case 'A':
                    OptionA.FillColor = Color.DarkRed;
                    OptionA.FillColor2 = Color.DarkRed;
                    break;
                case 'B':
                    OptionB.FillColor = Color.DarkRed;
                    OptionB.FillColor2 = Color.DarkRed;
                    break;
                case 'C':
                    OptionC.FillColor = Color.DarkRed;
                    OptionC.FillColor2 = Color.DarkRed;
                    break;
                case 'D':
                    OptionD.FillColor = Color.DarkRed;
                    OptionD.FillColor2 = Color.DarkRed;
                    break;
            }
        }
        private void GeneratePatterns()
        {
            int percent1 = random.Next(0, 100);
            int percent2 = random.Next(0, 100-percent1);
            int percent3 = random.Next(0, 100-percent1-percent2);
            int percent4 = random.Next(0, 100-percent1-percent2 - percent3);
            progressBar1.Value = percent1;
            progressBar2.Value = percent2;
            progressBar3.Value = percent3;
            progressBar4.Value = percent4;
        }

        private void label27_Click(object sender, EventArgs e)
        {

            panel14.Visible = false;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            panel13.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi {game.PlayerName.Split(' ')[0]},I will probably go for {GenerateLetter()} option", $"Message from {guna2Button2.Text}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guna2Button3.Enabled= false;
            guna2Button5.Enabled= false;
            guna2Button2.Enabled= false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi {game.PlayerName.Split(' ')[0]},I will probably go for {GenerateLetter()} option", $"Message from {guna2Button3.Text}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guna2Button2.Enabled = false;
            guna2Button5.Enabled = false;
            guna2Button3.Enabled = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi {game.PlayerName.Split(' ')[0]},I will probably go for {GenerateLetter()} option", $"Message from {guna2Button5.Text}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            guna2Button3.Enabled = false;
            guna2Button2.Enabled = false;
            guna2Button5.Enabled = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to quit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Quit = true;
                GameOver();
            }
        }
    }
}
