using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPS_WindowsForm
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            UserInformation ui = new UserInformation();
            ui.ShowDialog();
        }
    }
}
