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
    public partial class Form3 : Form
    {
        public Game game { get; set; }
        public Form3(Game game)
        {
            InitializeComponent();
            this.game = game;   
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                game.PlayerName = textBox1.Text;

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Milionaire.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
