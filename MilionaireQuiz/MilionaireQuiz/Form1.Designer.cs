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
            this.startGameBtn = new System.Windows.Forms.Button();
            this.trueFalseLabel = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.mainTitle.Location = new System.Drawing.Point(43, 34);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(780, 34);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "The Millionaire\'s Mind: Are You Up to the Challenge?";
            // 
            // startGameBtn
            // 
            this.startGameBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startGameBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.startGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.startGameBtn.Location = new System.Drawing.Point(76, 295);
            this.startGameBtn.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startGameBtn.Size = new System.Drawing.Size(250, 52);
            this.startGameBtn.TabIndex = 10;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // trueFalseLabel
            // 
            this.trueFalseLabel.AutoSize = true;
            this.trueFalseLabel.Location = new System.Drawing.Point(171, 375);
            this.trueFalseLabel.Name = "trueFalseLabel";
            this.trueFalseLabel.Size = new System.Drawing.Size(0, 13);
            this.trueFalseLabel.TabIndex = 13;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 60;
            this.guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2CustomGradientPanel1.BorderThickness = 3;
            this.guna2CustomGradientPanel1.Controls.Add(this.mainTitle);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Navy;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Navy;
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(174, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(870, 103);
            this.guna2CustomGradientPanel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(860, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(250, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Game Rules";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.trueFalseLabel);
            this.Controls.Add(this.startGameBtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Millionaire quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Label trueFalseLabel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Button button1;
    }
}

