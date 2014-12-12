/**
 * BaseForm is the parent form for all screens in the GameWorld application. The continue button leads to the next screen (implement tooltips)
 * the exit button closes the window.
 * */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPS_WindowsForm
{
    public partial class BaseForm : BaseObjects.Form1
    {
        public BaseForm()
        {
            InitializeComponent();
        }
    }
}
