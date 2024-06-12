namespace MilionaireQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTitle = new System.Windows.Forms.Label();
            this.choseCatBtn = new System.Windows.Forms.Button();
            this.highScoresBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.nextQuestionBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(219, 42);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(402, 28);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "WHO WANTS TO BE  A MILIONAIRE?";
            // 
            // choseCatBtn
            // 
            this.choseCatBtn.Location = new System.Drawing.Point(296, 132);
            this.choseCatBtn.Name = "choseCatBtn";
            this.choseCatBtn.Size = new System.Drawing.Size(196, 65);
            this.choseCatBtn.TabIndex = 1;
            this.choseCatBtn.Text = "Choose a category";
            this.choseCatBtn.UseVisualStyleBackColor = true;
            this.choseCatBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // highScoresBtn
            // 
            this.highScoresBtn.Location = new System.Drawing.Point(296, 209);
            this.highScoresBtn.Name = "highScoresBtn";
            this.highScoresBtn.Size = new System.Drawing.Size(196, 50);
            this.highScoresBtn.TabIndex = 2;
            this.highScoresBtn.Text = "High Scores";
            this.highScoresBtn.UseVisualStyleBackColor = true;
            this.highScoresBtn.Click += new System.EventHandler(this.highScoresBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 29);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sport";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(145, 29);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Geography";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(249, 40);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 29);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Music";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(347, 40);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(152, 29);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Technology";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(187, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 112);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Category";
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(296, 265);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(196, 52);
            this.startGameBtn.TabIndex = 10;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextQuestionBtn
            // 
            this.nextQuestionBtn.Location = new System.Drawing.Point(489, 343);
            this.nextQuestionBtn.Name = "nextQuestionBtn";
            this.nextQuestionBtn.Size = new System.Drawing.Size(197, 47);
            this.nextQuestionBtn.TabIndex = 11;
            this.nextQuestionBtn.Text = "next question";
            this.nextQuestionBtn.UseVisualStyleBackColor = true;
            this.nextQuestionBtn.Visible = false;
            this.nextQuestionBtn.Click += new System.EventHandler(this.nextQuestionBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextQuestionBtn);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.choseCatBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.highScoresBtn);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button choseCatBtn;
        private System.Windows.Forms.Button highScoresBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button nextQuestionBtn;
    }
}

