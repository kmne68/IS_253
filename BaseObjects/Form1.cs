using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            // TODO Add code for whatever this form continues to.

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Close whatever form is open
            this.Close();
        }
    }
}
