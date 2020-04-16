using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using SharpDX.DirectInput;
using SharpDX.XInput;

namespace jstest_windows_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            directInputControl1.AbortDInput();
            xInputControl1.abortXInput();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //begin operations once form constructed
            directInputControl1.LoadDirectInput();
            xInputControl1.LoadXInput();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                //DirectInput
                directInputControl1.DirectInputThreadControl.Set();
                xInputControl1.XInputThreadControl.Reset();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                //XInput
                directInputControl1.DirectInputThreadControl.Reset();
                xInputControl1.XInputThreadControl.Set();
            } 
            else
            {
                MessageBox.Show("Something went wrong with the form!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
