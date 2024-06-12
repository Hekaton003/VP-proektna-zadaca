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
            if(radioButton1.Visible)
            {
                groupBox1.Text = "Choose category";
            }
            else
            {
                groupBox1.Text = "Current Category "+game.Category;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choseCatBtn.Visible=true;
            highScoresBtn.Visible=true;
            displayCategoryRadioButtons();
        }

        private void loadQuestion(int index)
        {

        }

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

        }
    }
}
