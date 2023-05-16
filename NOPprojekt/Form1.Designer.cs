namespace NOPprojekt
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
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCurrentTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(31, 106);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer1.TabIndex = 0;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Location = new System.Drawing.Point(242, 106);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer2.TabIndex = 1;
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(165, 109);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(33, 13);
            this.labelHint.TabIndex = 2;
            this.labelHint.Text = "None";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(28, 70);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer1.TabIndex = 3;
            this.labelPlayer1.Text = "Player1";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(239, 70);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer2.TabIndex = 4;
            this.labelPlayer2.Text = "Player2";
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(31, 224);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(172, 57);
            this.buttonGuess.TabIndex = 5;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(32, 142);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 13);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "Score:";
            // 
            // labelCurrentTurn
            // 
            this.labelCurrentTurn.AutoSize = true;
            this.labelCurrentTurn.Location = new System.Drawing.Point(28, 25);
            this.labelCurrentTurn.Name = "labelCurrentTurn";
            this.labelCurrentTurn.Size = new System.Drawing.Size(65, 13);
            this.labelCurrentTurn.TabIndex = 7;
            this.labelCurrentTurn.Text = "Current turn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.labelCurrentTurn);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelCurrentTurn;
    }
}

