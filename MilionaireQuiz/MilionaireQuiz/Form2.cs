using Guna.UI2.WinForms;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.WordWrap = true;
         
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.ForeColor = Color.White;
            // Add event handler for scrolling
            Controls.Add(textBox1);
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Milionaire.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
