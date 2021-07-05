namespace Lingo
{
    partial class homepage
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
            System.Windows.Forms.Label label1;
            this.EasyBtn = new System.Windows.Forms.Button();
            this.MediumBtn = new System.Windows.Forms.Button();
            this.HardBtn = new System.Windows.Forms.Button();
            this.createUsernameBtn = new System.Windows.Forms.Button();
            this.howToPlayBtn = new System.Windows.Forms.Button();
            this.easyPanel = new System.Windows.Forms.Panel();
            this.guess5 = new System.Windows.Forms.TextBox();
            this.medPanel = new System.Windows.Forms.Panel();
            this.medGuess5 = new System.Windows.Forms.TextBox();
            this.medGuess4 = new System.Windows.Forms.TextBox();
            this.medGuess3 = new System.Windows.Forms.TextBox();
            this.medGuess2 = new System.Windows.Forms.TextBox();
            this.medGuess1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guess4 = new System.Windows.Forms.TextBox();
            this.guess3 = new System.Windows.Forms.TextBox();
            this.guess2 = new System.Windows.Forms.TextBox();
            this.guess1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hardPanel = new System.Windows.Forms.Panel();
            this.hardGuess5 = new System.Windows.Forms.TextBox();
            this.hardGuess4 = new System.Windows.Forms.TextBox();
            this.hardGuess3 = new System.Windows.Forms.TextBox();
            this.hardGuess2 = new System.Windows.Forms.TextBox();
            this.hardGuess1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.easyPanel.SuspendLayout();
            this.medPanel.SuspendLayout();
            this.hardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.CausesValidation = false;
            label1.Enabled = false;
            label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(78, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(154, 56);
            label1.TabIndex = 7;
            label1.Text = "Welcome To Word Guess";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EasyBtn
            // 
            this.EasyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EasyBtn.Location = new System.Drawing.Point(94, 161);
            this.EasyBtn.Name = "EasyBtn";
            this.EasyBtn.Size = new System.Drawing.Size(128, 36);
            this.EasyBtn.TabIndex = 1;
            this.EasyBtn.Text = "Easy";
            this.EasyBtn.UseVisualStyleBackColor = false;
            this.EasyBtn.Click += new System.EventHandler(this.EasyBtn_Click);
            // 
            // MediumBtn
            // 
            this.MediumBtn.Location = new System.Drawing.Point(94, 228);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(128, 36);
            this.MediumBtn.TabIndex = 2;
            this.MediumBtn.Text = "Medium";
            this.MediumBtn.UseVisualStyleBackColor = true;
            this.MediumBtn.Click += new System.EventHandler(this.MediumBtn_Click);
            // 
            // HardBtn
            // 
            this.HardBtn.Location = new System.Drawing.Point(94, 296);
            this.HardBtn.Name = "HardBtn";
            this.HardBtn.Size = new System.Drawing.Size(128, 36);
            this.HardBtn.TabIndex = 3;
            this.HardBtn.Text = "Hard";
            this.HardBtn.UseVisualStyleBackColor = true;
            this.HardBtn.Click += new System.EventHandler(this.HardBtn_Click);
            // 
            // createUsernameBtn
            // 
            this.createUsernameBtn.Location = new System.Drawing.Point(185, 376);
            this.createUsernameBtn.Name = "createUsernameBtn";
            this.createUsernameBtn.Size = new System.Drawing.Size(91, 39);
            this.createUsernameBtn.TabIndex = 4;
            this.createUsernameBtn.Text = "Create Username";
            this.createUsernameBtn.UseVisualStyleBackColor = true;
            this.createUsernameBtn.Click += new System.EventHandler(this.createUsernameBtn_Click);
            // 
            // howToPlayBtn
            // 
            this.howToPlayBtn.Location = new System.Drawing.Point(31, 376);
            this.howToPlayBtn.Name = "howToPlayBtn";
            this.howToPlayBtn.Size = new System.Drawing.Size(75, 39);
            this.howToPlayBtn.TabIndex = 5;
            this.howToPlayBtn.Text = "How To Play";
            this.howToPlayBtn.UseVisualStyleBackColor = true;
            this.howToPlayBtn.Click += new System.EventHandler(this.howToPlayBtn_Click);
            // 
            // easyPanel
            // 
            this.easyPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.easyPanel.CausesValidation = false;
            this.easyPanel.Controls.Add(this.guess5);
            this.easyPanel.Controls.Add(this.medPanel);
            this.easyPanel.Controls.Add(this.guess4);
            this.easyPanel.Controls.Add(this.guess3);
            this.easyPanel.Controls.Add(this.guess2);
            this.easyPanel.Controls.Add(this.guess1);
            this.easyPanel.Controls.Add(this.label2);
            this.easyPanel.Location = new System.Drawing.Point(17, 53);
            this.easyPanel.Name = "easyPanel";
            this.easyPanel.Size = new System.Drawing.Size(315, 384);
            this.easyPanel.TabIndex = 6;
            this.easyPanel.Visible = false;
            // 
            // guess5
            // 
            this.guess5.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.guess5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.guess5.Location = new System.Drawing.Point(81, 321);
            this.guess5.Name = "guess5";
            this.guess5.Size = new System.Drawing.Size(152, 38);
            this.guess5.TabIndex = 9;
            this.guess5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guess5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterFinal);
            // 
            // medPanel
            // 
            this.medPanel.BackColor = System.Drawing.Color.Gold;
            this.medPanel.Controls.Add(this.medGuess5);
            this.medPanel.Controls.Add(this.medGuess4);
            this.medPanel.Controls.Add(this.medGuess3);
            this.medPanel.Controls.Add(this.medGuess2);
            this.medPanel.Controls.Add(this.medGuess1);
            this.medPanel.Controls.Add(this.label3);
            this.medPanel.Location = new System.Drawing.Point(0, 0);
            this.medPanel.Name = "medPanel";
            this.medPanel.Size = new System.Drawing.Size(318, 384);
            this.medPanel.TabIndex = 8;
            this.medPanel.Visible = false;
            // 
            // medGuess5
            // 
            this.medGuess5.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.medGuess5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.medGuess5.Location = new System.Drawing.Point(82, 324);
            this.medGuess5.Name = "medGuess5";
            this.medGuess5.Size = new System.Drawing.Size(152, 38);
            this.medGuess5.TabIndex = 14;
            this.medGuess5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.medGuess5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.medEnterFinal);
            // 
            // medGuess4
            // 
            this.medGuess4.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.medGuess4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.medGuess4.Location = new System.Drawing.Point(82, 256);
            this.medGuess4.Name = "medGuess4";
            this.medGuess4.Size = new System.Drawing.Size(152, 38);
            this.medGuess4.TabIndex = 13;
            this.medGuess4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.medGuess4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterMed);
            // 
            // medGuess3
            // 
            this.medGuess3.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.medGuess3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.medGuess3.Location = new System.Drawing.Point(82, 188);
            this.medGuess3.Name = "medGuess3";
            this.medGuess3.Size = new System.Drawing.Size(152, 38);
            this.medGuess3.TabIndex = 12;
            this.medGuess3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.medGuess3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterMed);
            // 
            // medGuess2
            // 
            this.medGuess2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.medGuess2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.medGuess2.Location = new System.Drawing.Point(82, 121);
            this.medGuess2.Name = "medGuess2";
            this.medGuess2.Size = new System.Drawing.Size(152, 38);
            this.medGuess2.TabIndex = 11;
            this.medGuess2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.medGuess2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterMed);
            // 
            // medGuess1
            // 
            this.medGuess1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.medGuess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.medGuess1.Location = new System.Drawing.Point(82, 58);
            this.medGuess1.Name = "medGuess1";
            this.medGuess1.Size = new System.Drawing.Size(152, 38);
            this.medGuess1.TabIndex = 10;
            this.medGuess1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.medGuess1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterMed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "The secret word contains 5 letters";
            // 
            // guess4
            // 
            this.guess4.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.guess4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.guess4.Location = new System.Drawing.Point(81, 253);
            this.guess4.Name = "guess4";
            this.guess4.Size = new System.Drawing.Size(152, 38);
            this.guess4.TabIndex = 8;
            this.guess4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guess4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            // 
            // guess3
            // 
            this.guess3.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.guess3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.guess3.Location = new System.Drawing.Point(81, 185);
            this.guess3.Name = "guess3";
            this.guess3.Size = new System.Drawing.Size(152, 38);
            this.guess3.TabIndex = 7;
            this.guess3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guess3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            // 
            // guess2
            // 
            this.guess2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.guess2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.guess2.Location = new System.Drawing.Point(81, 118);
            this.guess2.Name = "guess2";
            this.guess2.Size = new System.Drawing.Size(152, 38);
            this.guess2.TabIndex = 6;
            this.guess2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guess2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            // 
            // guess1
            // 
            this.guess1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.guess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.guess1.Location = new System.Drawing.Point(81, 55);
            this.guess1.Name = "guess1";
            this.guess1.Size = new System.Drawing.Size(152, 38);
            this.guess1.TabIndex = 5;
            this.guess1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guess1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "The secret word contains 4 letters";
            // 
            // hardPanel
            // 
            this.hardPanel.BackColor = System.Drawing.Color.Firebrick;
            this.hardPanel.Controls.Add(this.hardGuess5);
            this.hardPanel.Controls.Add(this.hardGuess4);
            this.hardPanel.Controls.Add(this.hardGuess3);
            this.hardPanel.Controls.Add(this.hardGuess2);
            this.hardPanel.Controls.Add(this.hardGuess1);
            this.hardPanel.Controls.Add(this.label4);
            this.hardPanel.Location = new System.Drawing.Point(14, 53);
            this.hardPanel.Name = "hardPanel";
            this.hardPanel.Size = new System.Drawing.Size(318, 384);
            this.hardPanel.TabIndex = 9;
            this.hardPanel.Visible = false;
            this.hardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.hardPanel_Paint);
            // 
            // hardGuess5
            // 
            this.hardGuess5.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.hardGuess5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hardGuess5.Location = new System.Drawing.Point(84, 321);
            this.hardGuess5.Name = "hardGuess5";
            this.hardGuess5.Size = new System.Drawing.Size(152, 38);
            this.hardGuess5.TabIndex = 19;
            this.hardGuess5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hardGuess5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hardEnterFinal);
            // 
            // hardGuess4
            // 
            this.hardGuess4.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.hardGuess4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hardGuess4.Location = new System.Drawing.Point(84, 253);
            this.hardGuess4.Name = "hardGuess4";
            this.hardGuess4.Size = new System.Drawing.Size(152, 38);
            this.hardGuess4.TabIndex = 18;
            this.hardGuess4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hardGuess4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterHard);
            // 
            // hardGuess3
            // 
            this.hardGuess3.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.hardGuess3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hardGuess3.Location = new System.Drawing.Point(84, 185);
            this.hardGuess3.Name = "hardGuess3";
            this.hardGuess3.Size = new System.Drawing.Size(152, 38);
            this.hardGuess3.TabIndex = 17;
            this.hardGuess3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hardGuess3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterHard);
            // 
            // hardGuess2
            // 
            this.hardGuess2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.hardGuess2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hardGuess2.Location = new System.Drawing.Point(84, 118);
            this.hardGuess2.Name = "hardGuess2";
            this.hardGuess2.Size = new System.Drawing.Size(152, 38);
            this.hardGuess2.TabIndex = 16;
            this.hardGuess2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hardGuess2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterHard);
            // 
            // hardGuess1
            // 
            this.hardGuess1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.hardGuess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hardGuess1.Location = new System.Drawing.Point(84, 55);
            this.hardGuess1.Name = "hardGuess1";
            this.hardGuess1.Size = new System.Drawing.Size(152, 38);
            this.hardGuess1.TabIndex = 15;
            this.hardGuess1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hardGuess1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterHard);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "The secret word contains 6 letters";
            this.label4.Visible = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(14, 21);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(100, 25);
            this.ScoreLabel.TabIndex = 10;
            this.ScoreLabel.Text = "Score: 0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 449);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.hardPanel);
            this.Controls.Add(this.easyPanel);
            this.Controls.Add(this.howToPlayBtn);
            this.Controls.Add(this.createUsernameBtn);
            this.Controls.Add(this.HardBtn);
            this.Controls.Add(this.MediumBtn);
            this.Controls.Add(this.EasyBtn);
            this.Controls.Add(label1);
            this.Name = "homepage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.easyPanel.ResumeLayout(false);
            this.easyPanel.PerformLayout();
            this.medPanel.ResumeLayout(false);
            this.medPanel.PerformLayout();
            this.hardPanel.ResumeLayout(false);
            this.hardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EasyBtn;
        private System.Windows.Forms.Button MediumBtn;
        private System.Windows.Forms.Button HardBtn;
        private System.Windows.Forms.Button createUsernameBtn;
        private System.Windows.Forms.Button howToPlayBtn;
        private System.Windows.Forms.Panel easyPanel;
        private System.Windows.Forms.TextBox guess5;
        private System.Windows.Forms.TextBox guess4;
        private System.Windows.Forms.TextBox guess3;
        private System.Windows.Forms.TextBox guess2;
        private System.Windows.Forms.TextBox guess1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel medPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox medGuess5;
        private System.Windows.Forms.TextBox medGuess4;
        private System.Windows.Forms.TextBox medGuess3;
        private System.Windows.Forms.TextBox medGuess2;
        private System.Windows.Forms.TextBox medGuess1;
        private System.Windows.Forms.Panel hardPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hardGuess5;
        private System.Windows.Forms.TextBox hardGuess4;
        private System.Windows.Forms.TextBox hardGuess3;
        private System.Windows.Forms.TextBox hardGuess2;
        private System.Windows.Forms.TextBox hardGuess1;
        private System.Windows.Forms.Label ScoreLabel;
    }
}