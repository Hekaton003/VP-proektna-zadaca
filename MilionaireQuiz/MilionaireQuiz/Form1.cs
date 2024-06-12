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
        public Form1()
        {
            game = new Game();
            Game.loadQuestions();
            game.Category = "Sport";
            InitializeComponent();
            groupBox1.Text = "Current Category " + game.Category;
            moneyLabel.Text = "Current winings:" + game.Money + "$";
        }

        private void highScoresBtn_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // Hide the start button
            hideHighScoresAndChangeCategoryButtons();
            displayCategoryRadioButtons();
            // Hide the high scores button
            
        }
        private void hideHighScoresAndChangeCategoryButtons()
        {
            choseCatBtn.Visible = false;
            highScoresBtn.Visible = false;
        }
        private void displayCategoryRadioButtons()
        {
            radioButton1.Visible = !radioButton1.Visible;
            radioButton2.Visible = !radioButton2.Visible;
            radioButton3.Visible = !radioButton3.Visible;
            radioButton4.Visible = !radioButton4.Visible;
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choseCatBtn.Visible=true;
            highScoresBtn.Visible=true;
            displayCategoryRadioButtons();
        }

        private void loadQuestion(int index)
        {
            groupBox1.Text = game.CurrentQuestions[index].TheQuestion;
            radioButton1.Text = game.CurrentQuestions[index].Answers[0];
            radioButton2.Text = game.CurrentQuestions[index].Answers[1];
            radioButton3.Text = game.CurrentQuestions[index].Answers[2];
            radioButton4.Text = game.CurrentQuestions[index].Answers[3];
            
        }
        //ova e start button samo ne e taka krsten eventot
        private void button1_Click(object sender, EventArgs e)
        {
            hideHighScoresAndChangeCategoryButtons();
            startGameBtn.Visible = false;
            groupBox1.Text = "Current category " + game.Category;
            if (game.Category == "Sport")
            {
                game.loadAllQuestions("Sport");
                loadQuestion(0);
            }
            else if(game.Category == "Technology")
            {
                game.loadAllQuestions("Technology");
                loadQuestion(0);
            }
            else if (game.Category == "Music")
            {
                game.loadAllQuestions("Music");
                loadQuestion(0);
            }
            else
            {
                game.loadAllQuestions("Geography");
                loadQuestion(0);
            }
            game.HasStarted = true;
            nextQuestionBtn.Visible = true;
            if (!radioButton1.Visible)
            {
                displayCategoryRadioButtons();
            }
            moneyLabel.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!game.HasStarted)
            {
                game.Category = radioButton4.Text;
                groupBox1.Text = "Current Category " + game.Category;
            }
            else
            {

            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!game.HasStarted)
            {
                game.Category = radioButton3.Text;
                groupBox1.Text = "Current Category " + game.Category;
            }
            else
            {

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!game.HasStarted)
            {
                game.Category = radioButton2.Text;
                groupBox1.Text = "Current Category " + game.Category;
            }
            else
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!game.HasStarted)
            {
                game.Category = radioButton1.Text;
                groupBox1.Text = "Current Category " + game.Category;
            }
            else
            {

            }
        }

        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {
            bool gameOver = false;
            foreach(RadioButton r in groupBox1.Controls)
            {
                if (r.Checked)
                {
                    if (r.Text == game.CurrentQuestions[game.CurrentQuestionIndex].CorrectAnswer)
                    {
                        moneyLabel.Text = "Current Winings:";
                        if (game.CurrentQuestionIndex == 0)
                        {
                            moneyLabel.Text += "500$";
                        }
                        else if (game.CurrentQuestionIndex == 1)
                        {
                            moneyLabel.Text += "1000$";
                        }
                        else if(game.CurrentQuestionIndex==2)
                        {
                            moneyLabel.Text += "3000$";
                        }
                        else if (game.CurrentQuestionIndex == 3)
                        {
                            moneyLabel.Text += "5000$";
                        }
                        else if (game.CurrentQuestionIndex == 4)
                        {
                            moneyLabel.Text += "8000$";
                        }
                        else if (game.CurrentQuestionIndex == 5)
                        {
                            moneyLabel.Text += "14 000$";
                        }
                        else if (game.CurrentQuestionIndex == 6)
                        {
                            moneyLabel.Text += "30 000$";
                        }
                        else if (game.CurrentQuestionIndex == 7)
                        {
                            moneyLabel.Text += "58 000$";
                        }
                        else if (game.CurrentQuestionIndex == 8)
                        {
                            moneyLabel.Text += "86 000$";
                        }
                        else if (game.CurrentQuestionIndex == 9)
                        {
                            moneyLabel.Text += "125 000$";
                        }
                        else if (game.CurrentQuestionIndex == 10)
                        {
                            moneyLabel.Text += "500 000$";
                        }
                        else if (game.CurrentQuestionIndex == 11)
                        {
                            moneyLabel.Text += "1 000 000$";
                        }
                    }
                    else
                    {
                        gameOver = true;
                    }
                    break;
                }
            }
            if (!gameOver)
            {
                game.CurrentQuestionIndex++;
                loadQuestion(game.CurrentQuestionIndex);
            }
            else
            {
                nextQuestionBtn.Enabled = false;
            }
        }
    }
}
