namespace jstest_windows_gui
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
            this.XInput = new System.Windows.Forms.TabPage();
            this.DirectInput = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.colCapaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colButton = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCapaValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.directInputControl1 = new jstest_windows_gui.DirectInputControl();
            this.xInputControl1 = new jstest_windows_gui.XInputControl();
            this.XInput.SuspendLayout();
            this.DirectInput.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // XInput
            // 
            this.XInput.Controls.Add(this.xInputControl1);
            this.XInput.Location = new System.Drawing.Point(4, 22);
            this.XInput.Name = "XInput";
            this.XInput.Padding = new System.Windows.Forms.Padding(3);
            this.XInput.Size = new System.Drawing.Size(768, 407);
            this.XInput.TabIndex = 1;
            this.XInput.Text = "XInput";
            // 
            // DirectInput
            // 
            this.DirectInput.BackColor = System.Drawing.SystemColors.Control;
            this.DirectInput.Controls.Add(this.directInputControl1);
            this.DirectInput.Location = new System.Drawing.Point(4, 22);
            this.DirectInput.Name = "DirectInput";
            this.DirectInput.Padding = new System.Windows.Forms.Padding(3);
            this.DirectInput.Size = new System.Drawing.Size(768, 407);
            this.DirectInput.TabIndex = 0;
            this.DirectInput.Text = "DirectInput";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DirectInput);
            this.tabControl1.Controls.Add(this.XInput);
            this.tabControl1.Location = new System.Drawing.Point(12, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 433);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // colCapaName
            // 
            this.colCapaName.Text = "Capability";
            this.colCapaName.Width = 100;
            // 
            // colButton
            // 
            this.colButton.Text = "Button";
            this.colButton.Width = 100;
            // 
            // colVal
            // 
            this.colVal.Text = "Value";
            this.colVal.Width = 100;
            // 
            // colCapaValue
            // 
            this.colCapaValue.Text = "Value";
            this.colCapaValue.Width = 100;
            // 
            // directInputControl1
            // 
            this.directInputControl1.Location = new System.Drawing.Point(0, 0);
            this.directInputControl1.Name = "directInputControl1";
            this.directInputControl1.Size = new System.Drawing.Size(768, 407);
            this.directInputControl1.TabIndex = 0;
            // 
            // xInputControl1
            // 
            this.xInputControl1.Location = new System.Drawing.Point(0, 0);
            this.xInputControl1.Name = "xInputControl1";
            this.xInputControl1.Size = new System.Drawing.Size(768, 407);
            this.xInputControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "jstest-windows-gui (D/XInput)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.XInput.ResumeLayout(false);
            this.DirectInput.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage XInput;
        private System.Windows.Forms.TabPage DirectInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ColumnHeader colCapaName;
        private System.Windows.Forms.ColumnHeader colButton;
        private System.Windows.Forms.ColumnHeader colVal;
        private System.Windows.Forms.ColumnHeader colCapaValue;
        private XInputControl xInputControl1;
        private DirectInputControl directInputControl1;
    }
}

