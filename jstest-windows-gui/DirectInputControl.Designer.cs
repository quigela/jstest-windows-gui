namespace jstest_windows_gui
{
    partial class DirectInputControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DirectInputCapaList = new System.Windows.Forms.ListView();
            this.colCapaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCapaValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DirectInputSliderList = new System.Windows.Forms.ListView();
            this.colSlider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DirectInputReset = new System.Windows.Forms.Button();
            this.DirectInputButtonList = new System.Windows.Forms.ListView();
            this.colButNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colButValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DirectInputHatValue = new System.Windows.Forms.Label();
            this.DirectInputDeviceList = new System.Windows.Forms.ListBox();
            this.log_DirectInput = new System.Windows.Forms.RichTextBox();
            this.DirectInputHatList = new System.Windows.Forms.ListView();
            this.colHat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHatValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DirectInputCapaList
            // 
            this.DirectInputCapaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCapaName,
            this.colCapaValue});
            this.DirectInputCapaList.HideSelection = false;
            this.DirectInputCapaList.Location = new System.Drawing.Point(7, 217);
            this.DirectInputCapaList.Name = "DirectInputCapaList";
            this.DirectInputCapaList.Size = new System.Drawing.Size(333, 89);
            this.DirectInputCapaList.TabIndex = 28;
            this.DirectInputCapaList.UseCompatibleStateImageBehavior = false;
            this.DirectInputCapaList.View = System.Windows.Forms.View.Details;
            // 
            // colCapaName
            // 
            this.colCapaName.Text = "Capability";
            this.colCapaName.Width = 100;
            // 
            // colCapaValue
            // 
            this.colCapaValue.Text = "Value";
            this.colCapaValue.Width = 229;
            // 
            // DirectInputSliderList
            // 
            this.DirectInputSliderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSlider,
            this.colValue});
            this.DirectInputSliderList.HideSelection = false;
            this.DirectInputSliderList.Location = new System.Drawing.Point(346, 6);
            this.DirectInputSliderList.Name = "DirectInputSliderList";
            this.DirectInputSliderList.Size = new System.Drawing.Size(206, 300);
            this.DirectInputSliderList.TabIndex = 27;
            this.DirectInputSliderList.UseCompatibleStateImageBehavior = false;
            this.DirectInputSliderList.View = System.Windows.Forms.View.Details;
            // 
            // colSlider
            // 
            this.colSlider.Text = "Slider/Analog";
            this.colSlider.Width = 100;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 100;
            // 
            // DirectInputReset
            // 
            this.DirectInputReset.Location = new System.Drawing.Point(7, 121);
            this.DirectInputReset.Name = "DirectInputReset";
            this.DirectInputReset.Size = new System.Drawing.Size(75, 23);
            this.DirectInputReset.TabIndex = 26;
            this.DirectInputReset.Text = "Reset";
            this.DirectInputReset.UseVisualStyleBackColor = true;
            this.DirectInputReset.Click += new System.EventHandler(this.DirectInputReset_Click);
            // 
            // DirectInputButtonList
            // 
            this.DirectInputButtonList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colButNum,
            this.colButValue});
            this.DirectInputButtonList.HideSelection = false;
            this.DirectInputButtonList.Location = new System.Drawing.Point(558, 7);
            this.DirectInputButtonList.Name = "DirectInputButtonList";
            this.DirectInputButtonList.Size = new System.Drawing.Size(204, 300);
            this.DirectInputButtonList.TabIndex = 25;
            this.DirectInputButtonList.UseCompatibleStateImageBehavior = false;
            this.DirectInputButtonList.View = System.Windows.Forms.View.Details;
            // 
            // colButNum
            // 
            this.colButNum.Text = "Button";
            this.colButNum.Width = 100;
            // 
            // colButValue
            // 
            this.colButValue.Text = "Value";
            this.colButValue.Width = 100;
            // 
            // DirectInputHatValue
            // 
            this.DirectInputHatValue.AutoSize = true;
            this.DirectInputHatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectInputHatValue.Location = new System.Drawing.Point(198, 154);
            this.DirectInputHatValue.Name = "DirectInputHatValue";
            this.DirectInputHatValue.Size = new System.Drawing.Size(0, 20);
            this.DirectInputHatValue.TabIndex = 24;
            // 
            // DirectInputDeviceList
            // 
            this.DirectInputDeviceList.FormattingEnabled = true;
            this.DirectInputDeviceList.Location = new System.Drawing.Point(7, 7);
            this.DirectInputDeviceList.Name = "DirectInputDeviceList";
            this.DirectInputDeviceList.Size = new System.Drawing.Size(333, 108);
            this.DirectInputDeviceList.TabIndex = 22;
            this.DirectInputDeviceList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DirectInputDeviceList_MouseDoubleClick);
            // 
            // log_DirectInput
            // 
            this.log_DirectInput.BackColor = System.Drawing.SystemColors.Info;
            this.log_DirectInput.Location = new System.Drawing.Point(7, 312);
            this.log_DirectInput.Name = "log_DirectInput";
            this.log_DirectInput.ReadOnly = true;
            this.log_DirectInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.log_DirectInput.Size = new System.Drawing.Size(755, 89);
            this.log_DirectInput.TabIndex = 21;
            this.log_DirectInput.Text = "";
            // 
            // DirectInputHatList
            // 
            this.DirectInputHatList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHat,
            this.colHatValue});
            this.DirectInputHatList.HideSelection = false;
            this.DirectInputHatList.Location = new System.Drawing.Point(134, 121);
            this.DirectInputHatList.Name = "DirectInputHatList";
            this.DirectInputHatList.Size = new System.Drawing.Size(206, 90);
            this.DirectInputHatList.TabIndex = 29;
            this.DirectInputHatList.UseCompatibleStateImageBehavior = false;
            this.DirectInputHatList.View = System.Windows.Forms.View.Details;
            // 
            // colHat
            // 
            this.colHat.Text = "Hat";
            this.colHat.Width = 100;
            // 
            // colHatValue
            // 
            this.colHatValue.Text = "Value";
            this.colHatValue.Width = 100;
            // 
            // DirectInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DirectInputHatList);
            this.Controls.Add(this.DirectInputCapaList);
            this.Controls.Add(this.DirectInputSliderList);
            this.Controls.Add(this.DirectInputReset);
            this.Controls.Add(this.DirectInputButtonList);
            this.Controls.Add(this.DirectInputHatValue);
            this.Controls.Add(this.DirectInputDeviceList);
            this.Controls.Add(this.log_DirectInput);
            this.Name = "DirectInputControl";
            this.Size = new System.Drawing.Size(768, 407);
            this.Load += new System.EventHandler(this.DirectInputControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DirectInputCapaList;
        private System.Windows.Forms.ListView DirectInputSliderList;
        private System.Windows.Forms.ColumnHeader colSlider;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.Button DirectInputReset;
        private System.Windows.Forms.ListView DirectInputButtonList;
        private System.Windows.Forms.Label DirectInputHatValue;
        private System.Windows.Forms.ListBox DirectInputDeviceList;
        private System.Windows.Forms.RichTextBox log_DirectInput;
        private System.Windows.Forms.ListView DirectInputHatList;
        private System.Windows.Forms.ColumnHeader colHat;
        private System.Windows.Forms.ColumnHeader colHatValue;
        private System.Windows.Forms.ColumnHeader colCapaName;
        private System.Windows.Forms.ColumnHeader colCapaValue;
        private System.Windows.Forms.ColumnHeader colButNum;
        private System.Windows.Forms.ColumnHeader colButValue;
    }
}
