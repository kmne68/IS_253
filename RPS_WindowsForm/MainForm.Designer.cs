namespace RPS_WindowsForm
{
    partial class MainForm : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_continue_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_main.BackgroundImage")));
            // 
            // btn_continue
            // 
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click_1);
            // 
            // btn_continue_main
            // 
            this.btn_continue_main.BackColor = System.Drawing.SystemColors.Control;
            this.btn_continue_main.Location = new System.Drawing.Point(18, 313);
            this.btn_continue_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_continue_main.Name = "btn_continue_main";
            this.btn_continue_main.Size = new System.Drawing.Size(112, 32);
            this.btn_continue_main.TabIndex = 0;
            this.btn_continue_main.Text = "Launch DB";
            this.btn_continue_main.UseVisualStyleBackColor = false;
            this.btn_continue_main.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(776, 532);
            this.Controls.Add(this.btn_continue_main);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Game World";
            this.Controls.SetChildIndex(this.btn_continue_main, 0);
            this.Controls.SetChildIndex(this.btn_continue, 0);
            this.Controls.SetChildIndex(this.pnl_main, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_continue_main;
    }
}