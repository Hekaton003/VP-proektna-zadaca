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
    public partial class Form4 : Form
    {
        public Game game {get; set;}
        public Form4(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Milionaire.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            if (game != null)
            {
                label4.Text = game.PlayerName;
                label5.Text = game.Category;
                label6.Text = game.Money+"$";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
