namespace RPS_WindowsForm
{
    partial class LizardSpock
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
            this.btn_lizard = new System.Windows.Forms.Button();
            this.btn_spock = new System.Windows.Forms.Button();
            this.txt_computerChoice = new System.Windows.Forms.TextBox();
            this.txt_winner = new System.Windows.Forms.TextBox();
            this.pbx_rock = new System.Windows.Forms.PictureBox();
            this.pbx_paper = new System.Windows.Forms.PictureBox();
            this.pbx_scissors = new System.Windows.Forms.PictureBox();
            this.pbx_lizard = new System.Windows.Forms.PictureBox();
            this.pbx_spock = new System.Windows.Forms.PictureBox();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.lbl_computerChoice = new System.Windows.Forms.Label();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_lizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_spock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.lbl_winner);
            this.pnl_main.Controls.Add(this.lbl_computerChoice);
            this.pnl_main.Controls.Add(this.btn_playAgain);
            this.pnl_main.Controls.Add(this.pbx_spock);
            this.pnl_main.Controls.Add(this.pbx_lizard);
            this.pnl_main.Controls.Add(this.pbx_scissors);
            this.pnl_main.Controls.Add(this.pbx_paper);
            this.pnl_main.Controls.Add(this.pbx_rock);
            this.pnl_main.Controls.Add(this.txt_winner);
            this.pnl_main.Controls.Add(this.txt_computerChoice);
            this.pnl_main.Controls.Add(this.btn_spock);
            this.pnl_main.Controls.Add(this.btn_lizard);
            this.pnl_main.Controls.Add(this.btn_scissors);
            this.pnl_main.Controls.Add(this.btn_paper);
            this.pnl_main.Controls.Add(this.btn_rock);
            this.pnl_main.Size = new System.Drawing.Size(621, 380);
            // 
            // btn_continue
            // 
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_rock
            // 
            this.btn_rock.Location = new System.Drawing.Point(30, 23);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(75, 23);
            this.btn_rock.TabIndex = 0;
            this.btn_rock.Text = "Rock";
            this.btn_rock.UseVisualStyleBackColor = true;
            this.btn_rock.Click += new System.EventHandler(this.btn_rock_Click);
            // 
            // btn_paper
            // 
            this.btn_paper.Location = new System.Drawing.Point(30, 97);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(75, 23);
            this.btn_paper.TabIndex = 1;
            this.btn_paper.Text = "Paper";
            this.btn_paper.UseVisualStyleBackColor = true;
            this.btn_paper.Click += new System.EventHandler(this.btn_paper_Click);
            // 
            // btn_scissors
            // 
            this.btn_scissors.Location = new System.Drawing.Point(30, 167);
            this.btn_scissors.Name = "btn_scissors";
            this.btn_scissors.Size = new System.Drawing.Size(75, 23);
            this.btn_scissors.TabIndex = 2;
            this.btn_scissors.Text = "Scissors";
            this.btn_scissors.UseVisualStyleBackColor = true;
            this.btn_scissors.Click += new System.EventHandler(this.btn_scissors_Click);
            // 
            // btn_lizard
            // 
            this.btn_lizard.Location = new System.Drawing.Point(30, 243);
            this.btn_lizard.Name = "btn_lizard";
            this.btn_lizard.Size = new System.Drawing.Size(75, 23);
            this.btn_lizard.TabIndex = 3;
            this.btn_lizard.Text = "Lizard";
            this.btn_lizard.UseVisualStyleBackColor = true;
            this.btn_lizard.Click += new System.EventHandler(this.btn_lizard_Click);
            // 
            // btn_spock
            // 
            this.btn_spock.Location = new System.Drawing.Point(30, 312);
            this.btn_spock.Name = "btn_spock";
            this.btn_spock.Size = new System.Drawing.Size(75, 23);
            this.btn_spock.TabIndex = 4;
            this.btn_spock.Text = "Spock";
            this.btn_spock.UseVisualStyleBackColor = true;
            this.btn_spock.Click += new System.EventHandler(this.btn_spock_Click);
            // 
            // txt_computerChoice
            // 
            this.txt_computerChoice.Location = new System.Drawing.Point(391, 99);
            this.txt_computerChoice.Name = "txt_computerChoice";
            this.txt_computerChoice.Size = new System.Drawing.Size(100, 25);
            this.txt_computerChoice.TabIndex = 5;
            // 
            // txt_winner
            // 
            this.txt_winner.Location = new System.Drawing.Point(391, 228);
            this.txt_winner.Name = "txt_winner";
            this.txt_winner.Size = new System.Drawing.Size(100, 25);
            this.txt_winner.TabIndex = 6;
            // 
            // pbx_rock
            // 
            this.pbx_rock.Location = new System.Drawing.Point(128, 23);
            this.pbx_rock.Name = "pbx_rock";
            this.pbx_rock.Size = new System.Drawing.Size(100, 50);
            this.pbx_rock.TabIndex = 7;
            this.pbx_rock.TabStop = false;
            // 
            // pbx_paper
            // 
            this.pbx_paper.Location = new System.Drawing.Point(128, 97);
            this.pbx_paper.Name = "pbx_paper";
            this.pbx_paper.Size = new System.Drawing.Size(100, 50);
            this.pbx_paper.TabIndex = 8;
            this.pbx_paper.TabStop = false;
            // 
            // pbx_scissors
            // 
            this.pbx_scissors.Location = new System.Drawing.Point(128, 167);
            this.pbx_scissors.Name = "pbx_scissors";
            this.pbx_scissors.Size = new System.Drawing.Size(100, 50);
            this.pbx_scissors.TabIndex = 9;
            this.pbx_scissors.TabStop = false;
            // 
            // pbx_lizard
            // 
            this.pbx_lizard.Location = new System.Drawing.Point(128, 243);
            this.pbx_lizard.Name = "pbx_lizard";
            this.pbx_lizard.Size = new System.Drawing.Size(100, 50);
            this.pbx_lizard.TabIndex = 10;
            this.pbx_lizard.TabStop = false;
            // 
            // pbx_spock
            // 
            this.pbx_spock.Location = new System.Drawing.Point(128, 312);
            this.pbx_spock.Name = "pbx_spock";
            this.pbx_spock.Size = new System.Drawing.Size(100, 50);
            this.pbx_spock.TabIndex = 11;
            this.pbx_spock.TabStop = false;
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.Location = new System.Drawing.Point(446, 312);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(75, 23);
            this.btn_playAgain.TabIndex = 12;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = true;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // lbl_computerChoice
            // 
            this.lbl_computerChoice.AutoSize = true;
            this.lbl_computerChoice.Location = new System.Drawing.Point(391, 59);
            this.lbl_computerChoice.Name = "lbl_computerChoice";
            this.lbl_computerChoice.Size = new System.Drawing.Size(117, 18);
            this.lbl_computerChoice.TabIndex = 13;
            this.lbl_computerChoice.Text = "Computer Choice";
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Location = new System.Drawing.Point(391, 189);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(51, 18);
            this.lbl_winner.TabIndex = 14;
            this.lbl_winner.Text = "Winner";
            // 
            // LizardSpock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Name = "LizardSpock";
            this.Text = "LizardSpock";
            this.Load += new System.EventHandler(this.LizardSpock_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_lizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_spock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rock;
        private System.Windows.Forms.Button btn_spock;
        private System.Windows.Forms.Button btn_lizard;
        private System.Windows.Forms.Button btn_scissors;
        private System.Windows.Forms.Button btn_paper;
        private System.Windows.Forms.TextBox txt_winner;
        private System.Windows.Forms.TextBox txt_computerChoice;
        private System.Windows.Forms.PictureBox pbx_spock;
        private System.Windows.Forms.PictureBox pbx_lizard;
        private System.Windows.Forms.PictureBox pbx_scissors;
        private System.Windows.Forms.PictureBox pbx_paper;
        private System.Windows.Forms.PictureBox pbx_rock;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Label lbl_computerChoice;
    }
}