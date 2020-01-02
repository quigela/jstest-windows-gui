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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DirectInput = new System.Windows.Forms.TabPage();
            this.DirectInputButtonList = new System.Windows.Forms.ListView();
            this.colButton = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DirectInputXValue = new System.Windows.Forms.Label();
            this.DirectInputYValue = new System.Windows.Forms.Label();
            this.DirectInputZValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DirectInputRotXValue = new System.Windows.Forms.Label();
            this.DirectInputRotYValue = new System.Windows.Forms.Label();
            this.DirectInputRotZValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DirectInputHatValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectInputDeviceList = new System.Windows.Forms.ListBox();
            this.log_DirectInput = new System.Windows.Forms.RichTextBox();
            this.XInput = new System.Windows.Forms.TabPage();
            this.XInputHatRValue = new System.Windows.Forms.Label();
            this.XInputHatLValue = new System.Windows.Forms.Label();
            this.XInputHatDValue = new System.Windows.Forms.Label();
            this.XInputHatUValue = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.XInputButton1Value = new System.Windows.Forms.Label();
            this.XInputButton9Value = new System.Windows.Forms.Label();
            this.XInputButton8Value = new System.Windows.Forms.Label();
            this.XInputButton7Value = new System.Windows.Forms.Label();
            this.XInputButton6Value = new System.Windows.Forms.Label();
            this.XInputButton5Value = new System.Windows.Forms.Label();
            this.XInputButton4Value = new System.Windows.Forms.Label();
            this.XInputButton3Value = new System.Windows.Forms.Label();
            this.XInputButton2Value = new System.Windows.Forms.Label();
            this.XInputButton0Value = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.XInputRTrigValue = new System.Windows.Forms.Label();
            this.XInputLTrigValue = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.XInputRightYValue = new System.Windows.Forms.Label();
            this.XInputRightXValue = new System.Windows.Forms.Label();
            this.XInputLeftYValue = new System.Windows.Forms.Label();
            this.XInputLeftXValue = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.XInputCurrentIndexValue = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.log_XInput = new System.Windows.Forms.RichTextBox();
            this.XInputDeviceList = new System.Windows.Forms.ListBox();
            this.DirectInputReset = new System.Windows.Forms.Button();
            this.XInputRTrigProg = new jstest_windows_gui.TriggerProgressBar();
            this.XInputLTrigProg = new jstest_windows_gui.TriggerProgressBar();
            this.tabControl1.SuspendLayout();
            this.DirectInput.SuspendLayout();
            this.XInput.SuspendLayout();
            this.SuspendLayout();
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
            // DirectInput
            // 
            this.DirectInput.BackColor = System.Drawing.SystemColors.Control;
            this.DirectInput.Controls.Add(this.DirectInputReset);
            this.DirectInput.Controls.Add(this.DirectInputButtonList);
            this.DirectInput.Controls.Add(this.DirectInputXValue);
            this.DirectInput.Controls.Add(this.DirectInputYValue);
            this.DirectInput.Controls.Add(this.DirectInputZValue);
            this.DirectInput.Controls.Add(this.label7);
            this.DirectInput.Controls.Add(this.label6);
            this.DirectInput.Controls.Add(this.label5);
            this.DirectInput.Controls.Add(this.DirectInputRotXValue);
            this.DirectInput.Controls.Add(this.DirectInputRotYValue);
            this.DirectInput.Controls.Add(this.DirectInputRotZValue);
            this.DirectInput.Controls.Add(this.label4);
            this.DirectInput.Controls.Add(this.label3);
            this.DirectInput.Controls.Add(this.label2);
            this.DirectInput.Controls.Add(this.DirectInputHatValue);
            this.DirectInput.Controls.Add(this.label1);
            this.DirectInput.Controls.Add(this.DirectInputDeviceList);
            this.DirectInput.Controls.Add(this.log_DirectInput);
            this.DirectInput.Location = new System.Drawing.Point(4, 22);
            this.DirectInput.Name = "DirectInput";
            this.DirectInput.Padding = new System.Windows.Forms.Padding(3);
            this.DirectInput.Size = new System.Drawing.Size(768, 407);
            this.DirectInput.TabIndex = 0;
            this.DirectInput.Text = "DirectInput";
            // 
            // DirectInputButtonList
            // 
            this.DirectInputButtonList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colButton,
            this.colVal});
            this.DirectInputButtonList.HideSelection = false;
            this.DirectInputButtonList.Location = new System.Drawing.Point(558, 7);
            this.DirectInputButtonList.Name = "DirectInputButtonList";
            this.DirectInputButtonList.Size = new System.Drawing.Size(203, 300);
            this.DirectInputButtonList.TabIndex = 17;
            this.DirectInputButtonList.UseCompatibleStateImageBehavior = false;
            this.DirectInputButtonList.View = System.Windows.Forms.View.Details;
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
            // DirectInputXValue
            // 
            this.DirectInputXValue.AutoSize = true;
            this.DirectInputXValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectInputXValue.Location = new System.Drawing.Point(178, 177);
            this.DirectInputXValue.Name = "DirectInputXValue";
            this.DirectInputXValue.Size = new System.Drawing.Size(0, 20);
            this.DirectInputXValue.TabIndex = 16;
            // 
            // DirectInputYValue
            // 
            this.DirectInputYValue.AutoSize = true;
            this.DirectInputYValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectInputYValue.Location = new System.Drawing.Point(178, 209);
            this.DirectInputYValue.Name = "DirectInputYValue";
            this.DirectInputYValue.Size = new System.Drawing.Size(0, 20);
            this.DirectInputYValue.TabIndex = 15;
            // 
            // DirectInputZValue
            // 
            this.DirectInputZValue.AutoSize = true;
            this.DirectInputZValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectInputZValue.Location = new System.Drawing.Point(177, 238);
            this.DirectInputZValue.Name = "DirectInputZValue";
            this.DirectInputZValue.Size = new System.Drawing.Size(0, 20);
            this.DirectInputZValue.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Z:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "X:";
            // 
            // DirectInputRotXValue
            // 
            this.DirectInputRotXValue.AutoSize = true;
            this.DirectInputRotXValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectInputRotXValue.Location = new System.Drawing.Point(66, 177);
            this.DirectInputRotXValue.Name = "DirectInputRotXValue";
            this.DirectInputRotXValue.Size = new System.Drawing.Size(0, 20);
            this.DirectInputRotXValue.TabIndex = 10;
            // 
            // DirectInputRotYValue
            // 
            this.DirectInputRotYValue.AutoSize = true;
            this.DirectInputRotYValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectInputRotYValue.Location = new System.Drawing.Point(66, 209);
            this.DirectInputRotYValue.Name = "DirectInputRotYValue";
            this.DirectInputRotYValue.Size = new System.Drawing.Size(0, 20);
            this.DirectInputRotYValue.TabIndex = 9;
            // 
            // DirectInputRotZValue
            // 
            this.DirectInputRotZValue.AutoSize = true;
            this.DirectInputRotZValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectInputRotZValue.Location = new System.Drawing.Point(65, 238);
            this.DirectInputRotZValue.Name = "DirectInputRotZValue";
            this.DirectInputRotZValue.Size = new System.Drawing.Size(0, 20);
            this.DirectInputRotZValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rot Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rot Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rot X:";
            // 
            // DirectInputHatValue
            // 
            this.DirectInputHatValue.AutoSize = true;
            this.DirectInputHatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectInputHatValue.Location = new System.Drawing.Point(94, 268);
            this.DirectInputHatValue.Name = "DirectInputHatValue";
            this.DirectInputHatValue.Size = new System.Drawing.Size(0, 20);
            this.DirectInputHatValue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "POV Hat:";
            // 
            // DirectInputDeviceList
            // 
            this.DirectInputDeviceList.FormattingEnabled = true;
            this.DirectInputDeviceList.Location = new System.Drawing.Point(7, 7);
            this.DirectInputDeviceList.Name = "DirectInputDeviceList";
            this.DirectInputDeviceList.Size = new System.Drawing.Size(344, 108);
            this.DirectInputDeviceList.TabIndex = 1;
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
            this.log_DirectInput.TabIndex = 0;
            this.log_DirectInput.Text = "";
            // 
            // XInput
            // 
            this.XInput.Controls.Add(this.XInputRTrigProg);
            this.XInput.Controls.Add(this.XInputLTrigProg);
            this.XInput.Controls.Add(this.XInputHatRValue);
            this.XInput.Controls.Add(this.XInputHatLValue);
            this.XInput.Controls.Add(this.XInputHatDValue);
            this.XInput.Controls.Add(this.XInputHatUValue);
            this.XInput.Controls.Add(this.label21);
            this.XInput.Controls.Add(this.label20);
            this.XInput.Controls.Add(this.label19);
            this.XInput.Controls.Add(this.label18);
            this.XInput.Controls.Add(this.XInputButton1Value);
            this.XInput.Controls.Add(this.XInputButton9Value);
            this.XInput.Controls.Add(this.XInputButton8Value);
            this.XInput.Controls.Add(this.XInputButton7Value);
            this.XInput.Controls.Add(this.XInputButton6Value);
            this.XInput.Controls.Add(this.XInputButton5Value);
            this.XInput.Controls.Add(this.XInputButton4Value);
            this.XInput.Controls.Add(this.XInputButton3Value);
            this.XInput.Controls.Add(this.XInputButton2Value);
            this.XInput.Controls.Add(this.XInputButton0Value);
            this.XInput.Controls.Add(this.label17);
            this.XInput.Controls.Add(this.label16);
            this.XInput.Controls.Add(this.XInputRTrigValue);
            this.XInput.Controls.Add(this.XInputLTrigValue);
            this.XInput.Controls.Add(this.label15);
            this.XInput.Controls.Add(this.label14);
            this.XInput.Controls.Add(this.label13);
            this.XInput.Controls.Add(this.label12);
            this.XInput.Controls.Add(this.label11);
            this.XInput.Controls.Add(this.label10);
            this.XInput.Controls.Add(this.label9);
            this.XInput.Controls.Add(this.label8);
            this.XInput.Controls.Add(this.label22);
            this.XInput.Controls.Add(this.label23);
            this.XInput.Controls.Add(this.XInputRightYValue);
            this.XInput.Controls.Add(this.XInputRightXValue);
            this.XInput.Controls.Add(this.XInputLeftYValue);
            this.XInput.Controls.Add(this.XInputLeftXValue);
            this.XInput.Controls.Add(this.label24);
            this.XInput.Controls.Add(this.label25);
            this.XInput.Controls.Add(this.label26);
            this.XInput.Controls.Add(this.label27);
            this.XInput.Controls.Add(this.XInputCurrentIndexValue);
            this.XInput.Controls.Add(this.label28);
            this.XInput.Controls.Add(this.log_XInput);
            this.XInput.Controls.Add(this.XInputDeviceList);
            this.XInput.Location = new System.Drawing.Point(4, 22);
            this.XInput.Name = "XInput";
            this.XInput.Padding = new System.Windows.Forms.Padding(3);
            this.XInput.Size = new System.Drawing.Size(768, 407);
            this.XInput.TabIndex = 1;
            this.XInput.Text = "XInput";
            // 
            // XInputHatRValue
            // 
            this.XInputHatRValue.AutoSize = true;
            this.XInputHatRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputHatRValue.Location = new System.Drawing.Point(422, 176);
            this.XInputHatRValue.Name = "XInputHatRValue";
            this.XInputHatRValue.Size = new System.Drawing.Size(0, 20);
            this.XInputHatRValue.TabIndex = 94;
            // 
            // XInputHatLValue
            // 
            this.XInputHatLValue.AutoSize = true;
            this.XInputHatLValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputHatLValue.Location = new System.Drawing.Point(410, 146);
            this.XInputHatLValue.Name = "XInputHatLValue";
            this.XInputHatLValue.Size = new System.Drawing.Size(0, 20);
            this.XInputHatLValue.TabIndex = 93;
            // 
            // XInputHatDValue
            // 
            this.XInputHatDValue.AutoSize = true;
            this.XInputHatDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputHatDValue.Location = new System.Drawing.Point(416, 116);
            this.XInputHatDValue.Name = "XInputHatDValue";
            this.XInputHatDValue.Size = new System.Drawing.Size(0, 20);
            this.XInputHatDValue.TabIndex = 92;
            // 
            // XInputHatUValue
            // 
            this.XInputHatUValue.AutoSize = true;
            this.XInputHatUValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputHatUValue.Location = new System.Drawing.Point(393, 86);
            this.XInputHatUValue.Name = "XInputHatUValue";
            this.XInputHatUValue.Size = new System.Drawing.Size(0, 20);
            this.XInputHatUValue.TabIndex = 91;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(303, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 20);
            this.label21.TabIndex = 90;
            this.label21.Text = "DPAD RIGHT:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(303, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 20);
            this.label20.TabIndex = 89;
            this.label20.Text = "DPAD LEFT:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(303, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 20);
            this.label19.TabIndex = 88;
            this.label19.Text = "DPAD UP:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(303, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 20);
            this.label18.TabIndex = 87;
            this.label18.Text = "DPAD DOWN:";
            // 
            // XInputButton1Value
            // 
            this.XInputButton1Value.AutoSize = true;
            this.XInputButton1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton1Value.Location = new System.Drawing.Point(659, 37);
            this.XInputButton1Value.Name = "XInputButton1Value";
            this.XInputButton1Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton1Value.TabIndex = 86;
            // 
            // XInputButton9Value
            // 
            this.XInputButton9Value.AutoSize = true;
            this.XInputButton9Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton9Value.Location = new System.Drawing.Point(659, 277);
            this.XInputButton9Value.Name = "XInputButton9Value";
            this.XInputButton9Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton9Value.TabIndex = 85;
            // 
            // XInputButton8Value
            // 
            this.XInputButton8Value.AutoSize = true;
            this.XInputButton8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton8Value.Location = new System.Drawing.Point(659, 247);
            this.XInputButton8Value.Name = "XInputButton8Value";
            this.XInputButton8Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton8Value.TabIndex = 84;
            // 
            // XInputButton7Value
            // 
            this.XInputButton7Value.AutoSize = true;
            this.XInputButton7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton7Value.Location = new System.Drawing.Point(659, 217);
            this.XInputButton7Value.Name = "XInputButton7Value";
            this.XInputButton7Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton7Value.TabIndex = 83;
            // 
            // XInputButton6Value
            // 
            this.XInputButton6Value.AutoSize = true;
            this.XInputButton6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton6Value.Location = new System.Drawing.Point(659, 189);
            this.XInputButton6Value.Name = "XInputButton6Value";
            this.XInputButton6Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton6Value.TabIndex = 82;
            // 
            // XInputButton5Value
            // 
            this.XInputButton5Value.AutoSize = true;
            this.XInputButton5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton5Value.Location = new System.Drawing.Point(659, 160);
            this.XInputButton5Value.Name = "XInputButton5Value";
            this.XInputButton5Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton5Value.TabIndex = 81;
            // 
            // XInputButton4Value
            // 
            this.XInputButton4Value.AutoSize = true;
            this.XInputButton4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton4Value.Location = new System.Drawing.Point(659, 127);
            this.XInputButton4Value.Name = "XInputButton4Value";
            this.XInputButton4Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton4Value.TabIndex = 80;
            // 
            // XInputButton3Value
            // 
            this.XInputButton3Value.AutoSize = true;
            this.XInputButton3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton3Value.Location = new System.Drawing.Point(659, 97);
            this.XInputButton3Value.Name = "XInputButton3Value";
            this.XInputButton3Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton3Value.TabIndex = 79;
            // 
            // XInputButton2Value
            // 
            this.XInputButton2Value.AutoSize = true;
            this.XInputButton2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton2Value.Location = new System.Drawing.Point(659, 67);
            this.XInputButton2Value.Name = "XInputButton2Value";
            this.XInputButton2Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton2Value.TabIndex = 78;
            // 
            // XInputButton0Value
            // 
            this.XInputButton0Value.AutoSize = true;
            this.XInputButton0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputButton0Value.Location = new System.Drawing.Point(659, 7);
            this.XInputButton0Value.Name = "XInputButton0Value";
            this.XInputButton0Value.Size = new System.Drawing.Size(0, 20);
            this.XInputButton0Value.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(520, 277);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 20);
            this.label17.TabIndex = 76;
            this.label17.Text = "Button 9 (RS):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(520, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 20);
            this.label16.TabIndex = 75;
            this.label16.Text = "Button 8 (LS):";
            // 
            // XInputRTrigValue
            // 
            this.XInputRTrigValue.AutoSize = true;
            this.XInputRTrigValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputRTrigValue.Location = new System.Drawing.Point(225, 245);
            this.XInputRTrigValue.Name = "XInputRTrigValue";
            this.XInputRTrigValue.Size = new System.Drawing.Size(0, 20);
            this.XInputRTrigValue.TabIndex = 74;
            // 
            // XInputLTrigValue
            // 
            this.XInputLTrigValue.AutoSize = true;
            this.XInputLTrigValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputLTrigValue.Location = new System.Drawing.Point(62, 245);
            this.XInputLTrigValue.Name = "XInputLTrigValue";
            this.XInputLTrigValue.Size = new System.Drawing.Size(0, 20);
            this.XInputLTrigValue.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(157, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 72;
            this.label15.Text = "RightT:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 20);
            this.label14.TabIndex = 71;
            this.label14.Text = "LeftT:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(520, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 70;
            this.label13.Text = "Button 7 (Start):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(520, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 69;
            this.label12.Text = "Button 6 (Back):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(520, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Button 5 (RB):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(520, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 67;
            this.label10.Text = "Button 4 (LB):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Button 2 (X):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(520, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Button 3 (Y):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(520, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 20);
            this.label22.TabIndex = 64;
            this.label22.Text = "Button 1 (B):";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(520, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 20);
            this.label23.TabIndex = 63;
            this.label23.Text = "Button 0 (A):";
            // 
            // XInputRightYValue
            // 
            this.XInputRightYValue.AutoSize = true;
            this.XInputRightYValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputRightYValue.Location = new System.Drawing.Point(225, 116);
            this.XInputRightYValue.Name = "XInputRightYValue";
            this.XInputRightYValue.Size = new System.Drawing.Size(0, 20);
            this.XInputRightYValue.TabIndex = 62;
            // 
            // XInputRightXValue
            // 
            this.XInputRightXValue.AutoSize = true;
            this.XInputRightXValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputRightXValue.Location = new System.Drawing.Point(225, 86);
            this.XInputRightXValue.Name = "XInputRightXValue";
            this.XInputRightXValue.Size = new System.Drawing.Size(0, 20);
            this.XInputRightXValue.TabIndex = 61;
            // 
            // XInputLeftYValue
            // 
            this.XInputLeftYValue.AutoSize = true;
            this.XInputLeftYValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputLeftYValue.Location = new System.Drawing.Point(64, 116);
            this.XInputLeftYValue.Name = "XInputLeftYValue";
            this.XInputLeftYValue.Size = new System.Drawing.Size(0, 20);
            this.XInputLeftYValue.TabIndex = 60;
            // 
            // XInputLeftXValue
            // 
            this.XInputLeftXValue.AutoSize = true;
            this.XInputLeftXValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputLeftXValue.Location = new System.Drawing.Point(64, 86);
            this.XInputLeftXValue.Name = "XInputLeftXValue";
            this.XInputLeftXValue.Size = new System.Drawing.Size(0, 20);
            this.XInputLeftXValue.TabIndex = 59;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(157, 86);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 20);
            this.label24.TabIndex = 58;
            this.label24.Text = "RightX:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(157, 116);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 20);
            this.label25.TabIndex = 57;
            this.label25.Text = "RightY:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 116);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 20);
            this.label26.TabIndex = 56;
            this.label26.Text = "LeftY:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 86);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 20);
            this.label27.TabIndex = 55;
            this.label27.Text = "LeftX:";
            // 
            // XInputCurrentIndexValue
            // 
            this.XInputCurrentIndexValue.AutoSize = true;
            this.XInputCurrentIndexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XInputCurrentIndexValue.Location = new System.Drawing.Point(277, 18);
            this.XInputCurrentIndexValue.Name = "XInputCurrentIndexValue";
            this.XInputCurrentIndexValue.Size = new System.Drawing.Size(0, 20);
            this.XInputCurrentIndexValue.TabIndex = 54;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(106, 18);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(165, 20);
            this.label28.TabIndex = 53;
            this.label28.Text = "Current XInput Player:";
            // 
            // log_XInput
            // 
            this.log_XInput.BackColor = System.Drawing.SystemColors.Info;
            this.log_XInput.Location = new System.Drawing.Point(7, 312);
            this.log_XInput.Name = "log_XInput";
            this.log_XInput.ReadOnly = true;
            this.log_XInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.log_XInput.Size = new System.Drawing.Size(755, 89);
            this.log_XInput.TabIndex = 1;
            this.log_XInput.Text = "";
            // 
            // XInputDeviceList
            // 
            this.XInputDeviceList.FormattingEnabled = true;
            this.XInputDeviceList.Location = new System.Drawing.Point(7, 7);
            this.XInputDeviceList.Name = "XInputDeviceList";
            this.XInputDeviceList.Size = new System.Drawing.Size(82, 69);
            this.XInputDeviceList.TabIndex = 0;
            this.XInputDeviceList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.XInputDeviceList_MouseDoubleClick);
            // 
            // DirectInputReset
            // 
            this.DirectInputReset.Location = new System.Drawing.Point(7, 121);
            this.DirectInputReset.Name = "DirectInputReset";
            this.DirectInputReset.Size = new System.Drawing.Size(75, 23);
            this.DirectInputReset.TabIndex = 18;
            this.DirectInputReset.Text = "Reset";
            this.DirectInputReset.UseVisualStyleBackColor = true;
            this.DirectInputReset.Click += new System.EventHandler(this.DirectInputReset_Click);
            // 
            // XInputRTrigProg
            // 
            this.XInputRTrigProg.ForeColor = System.Drawing.Color.HotPink;
            this.XInputRTrigProg.Location = new System.Drawing.Point(161, 218);
            this.XInputRTrigProg.Maximum = 255;
            this.XInputRTrigProg.Name = "XInputRTrigProg";
            this.XInputRTrigProg.Size = new System.Drawing.Size(115, 23);
            this.XInputRTrigProg.TabIndex = 96;
            // 
            // XInputLTrigProg
            // 
            this.XInputLTrigProg.ForeColor = System.Drawing.Color.HotPink;
            this.XInputLTrigProg.Location = new System.Drawing.Point(10, 219);
            this.XInputLTrigProg.Maximum = 255;
            this.XInputLTrigProg.Name = "XInputLTrigProg";
            this.XInputLTrigProg.Size = new System.Drawing.Size(115, 23);
            this.XInputLTrigProg.TabIndex = 95;
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
            this.tabControl1.ResumeLayout(false);
            this.DirectInput.ResumeLayout(false);
            this.DirectInput.PerformLayout();
            this.XInput.ResumeLayout(false);
            this.XInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DirectInput;
        private System.Windows.Forms.TabPage XInput;
        private System.Windows.Forms.RichTextBox log_DirectInput;
        private System.Windows.Forms.ListBox DirectInputDeviceList;
        private System.Windows.Forms.Label DirectInputHatValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DirectInputRotXValue;
        private System.Windows.Forms.Label DirectInputRotYValue;
        private System.Windows.Forms.Label DirectInputRotZValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DirectInputXValue;
        private System.Windows.Forms.Label DirectInputYValue;
        private System.Windows.Forms.Label DirectInputZValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView DirectInputButtonList;
        private System.Windows.Forms.ColumnHeader colButton;
        private System.Windows.Forms.ColumnHeader colVal;
        private System.Windows.Forms.ListBox XInputDeviceList;
        private System.Windows.Forms.RichTextBox log_XInput;
        private System.Windows.Forms.Label XInputHatRValue;
        private System.Windows.Forms.Label XInputHatLValue;
        private System.Windows.Forms.Label XInputHatDValue;
        private System.Windows.Forms.Label XInputHatUValue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label XInputButton1Value;
        private System.Windows.Forms.Label XInputButton9Value;
        private System.Windows.Forms.Label XInputButton8Value;
        private System.Windows.Forms.Label XInputButton7Value;
        private System.Windows.Forms.Label XInputButton6Value;
        private System.Windows.Forms.Label XInputButton5Value;
        private System.Windows.Forms.Label XInputButton4Value;
        private System.Windows.Forms.Label XInputButton3Value;
        private System.Windows.Forms.Label XInputButton2Value;
        private System.Windows.Forms.Label XInputButton0Value;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label XInputRTrigValue;
        private System.Windows.Forms.Label XInputLTrigValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label XInputRightYValue;
        private System.Windows.Forms.Label XInputRightXValue;
        private System.Windows.Forms.Label XInputLeftYValue;
        private System.Windows.Forms.Label XInputLeftXValue;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label XInputCurrentIndexValue;
        private System.Windows.Forms.Label label28;
        private TriggerProgressBar XInputRTrigProg;
        private TriggerProgressBar XInputLTrigProg;
        private System.Windows.Forms.Button DirectInputReset;
    }
}

