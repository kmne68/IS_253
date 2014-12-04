﻿namespace RPS_WindowsForm
{
    partial class RPS_Form
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
            this.btn_rock = new System.Windows.Forms.Button();
            this.btn_paper = new System.Windows.Forms.Button();
            this.btn_scissors = new System.Windows.Forms.Button();
            this.txt_computerChoice = new System.Windows.Forms.TextBox();
            this.txt_winner = new System.Windows.Forms.TextBox();
            this.lbl_computerChoice = new System.Windows.Forms.Label();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.lbl_playerChoice = new System.Windows.Forms.Label();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.lbl_playerChoice);
            this.pnl_main.Controls.Add(this.btn_rock);
            this.pnl_main.Controls.Add(this.btn_playAgain);
            this.pnl_main.Controls.Add(this.btn_paper);
            this.pnl_main.Controls.Add(this.btn_scissors);
            this.pnl_main.Controls.Add(this.lbl_winner);
            this.pnl_main.Controls.Add(this.txt_computerChoice);
            this.pnl_main.Controls.Add(this.lbl_computerChoice);
            this.pnl_main.Controls.Add(this.txt_winner);
            this.pnl_main.Size = new System.Drawing.Size(621, 353);
            // 
            // btn_rock
            // 
            this.btn_rock.Location = new System.Drawing.Point(49, 82);
            this.btn_rock.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(112, 32);
            this.btn_rock.TabIndex = 0;
            this.btn_rock.Text = "Rock";
            this.btn_rock.UseVisualStyleBackColor = true;
            this.btn_rock.Click += new System.EventHandler(this.btn_rock_Click);
            // 
            // btn_paper
            // 
            this.btn_paper.Location = new System.Drawing.Point(49, 154);
            this.btn_paper.Margin = new System.Windows.Forms.Padding(4);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(112, 32);
            this.btn_paper.TabIndex = 1;
            this.btn_paper.Text = "Paper";
            this.btn_paper.UseVisualStyleBackColor = true;
            this.btn_paper.Click += new System.EventHandler(this.btn_paper_Click);
            // 
            // btn_scissors
            // 
            this.btn_scissors.Location = new System.Drawing.Point(49, 233);
            this.btn_scissors.Margin = new System.Windows.Forms.Padding(4);
            this.btn_scissors.Name = "btn_scissors";
            this.btn_scissors.Size = new System.Drawing.Size(112, 32);
            this.btn_scissors.TabIndex = 2;
            this.btn_scissors.Text = "Scissors";
            this.btn_scissors.UseVisualStyleBackColor = true;
            this.btn_scissors.Click += new System.EventHandler(this.btn_scissors_Click);
            // 
            // txt_computerChoice
            // 
            this.txt_computerChoice.Location = new System.Drawing.Point(238, 92);
            this.txt_computerChoice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_computerChoice.Name = "txt_computerChoice";
            this.txt_computerChoice.Size = new System.Drawing.Size(148, 25);
            this.txt_computerChoice.TabIndex = 3;
            // 
            // txt_winner
            // 
            this.txt_winner.Location = new System.Drawing.Point(238, 222);
            this.txt_winner.Margin = new System.Windows.Forms.Padding(4);
            this.txt_winner.Name = "txt_winner";
            this.txt_winner.Size = new System.Drawing.Size(148, 25);
            this.txt_winner.TabIndex = 4;
            // 
            // lbl_computerChoice
            // 
            this.lbl_computerChoice.AutoSize = true;
            this.lbl_computerChoice.Location = new System.Drawing.Point(234, 34);
            this.lbl_computerChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_computerChoice.Name = "lbl_computerChoice";
            this.lbl_computerChoice.Size = new System.Drawing.Size(117, 18);
            this.lbl_computerChoice.TabIndex = 5;
            this.lbl_computerChoice.Text = "Computer Choice";
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Location = new System.Drawing.Point(238, 183);
            this.lbl_winner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(51, 18);
            this.lbl_winner.TabIndex = 6;
            this.lbl_winner.Text = "Winner";
            // 
            // lbl_playerChoice
            // 
            this.lbl_playerChoice.AutoSize = true;
            this.lbl_playerChoice.Location = new System.Drawing.Point(54, 34);
            this.lbl_playerChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_playerChoice.Name = "lbl_playerChoice";
            this.lbl_playerChoice.Size = new System.Drawing.Size(92, 18);
            this.lbl_playerChoice.TabIndex = 7;
            this.lbl_playerChoice.Text = "Player Choice";
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.Location = new System.Drawing.Point(241, 287);
            this.btn_playAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(112, 32);
            this.btn_playAgain.TabIndex = 8;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = true;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // RPS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RPS_Form";
            this.Text = "Rock Paper Scissors";
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rock;
        private System.Windows.Forms.Button btn_paper;
        private System.Windows.Forms.Button btn_scissors;
        private System.Windows.Forms.TextBox txt_computerChoice;
        private System.Windows.Forms.TextBox txt_winner;
        private System.Windows.Forms.Label lbl_computerChoice;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Label lbl_playerChoice;
        private System.Windows.Forms.Button btn_playAgain;
    }
}

