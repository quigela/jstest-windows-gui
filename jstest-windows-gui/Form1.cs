using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using SharpDX.DirectInput;
using SharpDX.XInput;

namespace jstest_windows_gui
{
    public partial class Form1 : Form
    {
        DirectInputBroker dBroker;
        Thread DirectInputThread = null;
        ManualResetEvent DirectInputThreadControl = new ManualResetEvent(true);

        XInputBroker xBroker;
        Thread XInputThread = null;
        ManualResetEvent XInputThreadControl = new ManualResetEvent(true);

        public Form1()
        {
            dBroker = new DirectInputBroker();
            xBroker = new XInputBroker();
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DirectInputThread != null)
            {
                DirectInputThread.Abort();
            }
            if (XInputThread != null)
            {
                XInputThread.Abort();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //begin operations once form constructed
            this.LoadDirectInput();
            this.LoadXInput();
        }

        private void LoadXInput()
        {
            LogXInput("Adding XInput devices...");

            XInputDeviceList.Items.AddRange(xBroker.getDevices().ToArray());

            LogXInput("Double-Click Player to connect...");
        }

        private void LogXInput(string msg)
        {
            log_XInput.AppendText(msg + "\n");
            log_XInput.SelectionStart = log_DirectInput.TextLength;
            log_XInput.ScrollToCaret();
        }

        private void XInputInterval()
        {
            Controller c = xBroker.getSelectedController();
            State previousState = new State();
            while (true)
            {
                XInputThreadControl.WaitOne();
                //Console.WriteLine("poll XInput");

                if (!c.IsConnected)
                {
                    this.Invoke((MethodInvoker)delegate { 
                        LogXInput("Selected XInput controller is no longer available!");
                    });
                    if (XInputThread != null) { XInputThread.Abort(); }
                }

                var state = c.GetState();
                if (previousState.PacketNumber != state.PacketNumber)
                    this.Invoke((MethodInvoker)delegate
                    {
                        XInputLeftXValue.Text = state.Gamepad.LeftThumbX.ToString();
                        XInputLeftYValue.Text = state.Gamepad.LeftThumbY.ToString();
                        XInputLTrigValue.Text = state.Gamepad.LeftTrigger.ToString();
                        XInputLTrigProg.Value = state.Gamepad.LeftTrigger;

                        XInputRightXValue.Text = state.Gamepad.RightThumbX.ToString();
                        XInputRightYValue.Text = state.Gamepad.RightThumbY.ToString();
                        XInputRTrigValue.Text = state.Gamepad.RightTrigger.ToString();
                        XInputRTrigProg.Value = state.Gamepad.RightTrigger;

                        XInputButton0Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.A).ToString();
                        XInputButton1Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.B).ToString();
                        XInputButton2Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.X).ToString();
                        XInputButton3Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.Y).ToString();
                        XInputButton4Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.LeftShoulder).ToString();
                        XInputButton5Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.RightShoulder).ToString();
                        XInputButton6Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.Back).ToString();
                        XInputButton7Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.Start).ToString();
                        XInputButton8Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.LeftThumb).ToString();
                        XInputButton9Value.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.RightThumb).ToString();

                        XInputHatUValue.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.DPadUp).ToString();
                        XInputHatDValue.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.DPadDown).ToString();
                        XInputHatLValue.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.DPadLeft).ToString();
                        XInputHatRValue.Text = (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.DPadRight).ToString();
                    });
                previousState = state;
                Thread.Sleep(50);
            }
        }

        private void XInputDeviceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.XInputDeviceList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (XInputThread != null) { XInputThread.Abort(); }
                UserIndex controllerIndex;
                XInputBroker.IndexMap.TryGetValue(XInputDeviceList.Items[index].ToString(), out controllerIndex);
                LogXInput("Attaching to XInput controller: " + XInputDeviceList.Items[index].ToString());

                if (xBroker.selectController(controllerIndex))
                {
                    LogXInput("Attached to " + controllerIndex.ToString() + "!");
                    XInputThread = new Thread(XInputInterval);
                    XInputThread.Start();
                }
                else
                {
                    LogXInput("XInput controller " + controllerIndex.ToString() + " is not available");
                    //if (XInputThread != null) { XInputThread.Abort(); }
                }

                
            }
        }

        private void LoadDirectInput()
        {
            LogDirectInput("Searching DirectInput devices...");

            if (!dBroker.devsFound())
            {
                LogDirectInput("No DirectInput devices detected.");
            }
            else
            {
                DirectInputDeviceList.Items.AddRange(dBroker.getGuidList().ToArray());
                /*
                 * same as line above
                 * foreach (Guid g in dBroker.getGuidList())
                {
                    DirectInputDeviceList.Items.Add(g.ToString());
                    LogDirectInput("DirectInput device found: " + g.ToString());
                }*/
            }

            LogDirectInput("Double-Click GUID to attach...");

            //double-buffering the list to prevent update-flickering
            typeof(Control).InvokeMember("DoubleBuffered",
              BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
              null, DirectInputButtonList, new object[] { true });
        }

        private void LogDirectInput(string msg)
        {
            log_DirectInput.AppendText(msg + "\n");
            log_DirectInput.SelectionStart = log_DirectInput.TextLength;
            log_DirectInput.ScrollToCaret();
        }

        private void DirectInputInterval()
        {
            
            Joystick joystick = dBroker.getInstance();
            
            while (true)
            {
                DirectInputThreadControl.WaitOne();
                //Console.WriteLine("poll DirectInput");

                try
                {
                    joystick.Poll();
                    JoystickState state = joystick.GetCurrentState();
                    //if))
                    this.Invoke((MethodInvoker)delegate
                    {

                        DirectInputHatValue.Text = state.PointOfViewControllers.GetValue(0).ToString() +
                                                    ", " + state.PointOfViewControllers.GetValue(1).ToString() +
                                                    ", " + state.PointOfViewControllers.GetValue(2).ToString() +
                                                    ", " + state.PointOfViewControllers.GetValue(3).ToString();

                        DirectInputRotXValue.Text = state.RotationX.ToString();
                        DirectInputRotYValue.Text = state.RotationY.ToString();
                        DirectInputRotZValue.Text = state.RotationZ.ToString();

                        DirectInputXValue.Text = state.X.ToString();
                        DirectInputYValue.Text = state.Y.ToString();
                        DirectInputZValue.Text = state.Z.ToString();

                        //Console.WriteLine(state);
                        //state.
                        //int scrollPos = DirectInputButtonList.
                        DirectInputButtonList.BeginUpdate();
                        //DirectInputButtonList.Items.Clear();
                        for (int i = 0; i < state.Buttons.Length; i++)
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = i.ToString();
                            item.SubItems.Add(state.Buttons[i].ToString());
                            //DirectInputButtonList.Items.Add("colButton").Text = (i.ToString());
                            //DirectInputButtonList.Items.Add("colValue").Text = (state.Buttons[i].ToString());
                            if (DirectInputButtonList.Items.Count <= (i + 1))
                            {
                                DirectInputButtonList.Items.Add(item);
                            }
                            else
                            {
                                DirectInputButtonList.Items[i] = item;
                            }

                        }
                        DirectInputButtonList.EndUpdate();

                    });
                }
                catch (Exception ex) when (ex is SharpDX.SharpDXException || ex is System.NullReferenceException)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        LogDirectInput("Connection lost!");
                        dBroker.voidInstance();
                        if (DirectInputThread != null) { DirectInputThread.Abort(); }
                    });
                }
                Thread.Sleep(50);
            }
        }

        private void DirectInputDeviceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.DirectInputDeviceList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (DirectInputThread != null) { DirectInputThread.Abort(); }
                Guid guid = Guid.Parse(DirectInputDeviceList.Items[index].ToString());
                LogDirectInput("Attaching to DirectInput device: " + guid.ToString());
                if(dBroker.createInstance(guid))
                {
                    DirectInputThread = new Thread(DirectInputInterval);
                    DirectInputThread.Start();
                } 
                else
                {
                    LogDirectInput("Unable to attach!");
                }
                
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                //DirectInput
                if (DirectInputThread != null)
                {
                    DirectInputThreadControl.Set();
                }
                if (XInputThread != null)
                {
                    XInputThreadControl.Reset();
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                //XInput
                if (DirectInputThread != null)
                {
                    DirectInputThreadControl.Reset();
                }
                if (XInputThread != null)
                {
                    XInputThreadControl.Set();
                }
            } 
            else
            {
                MessageBox.Show("Something went wrong with the form!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void DirectInputReset_Click(object sender, EventArgs e)
        {
            if (DirectInputThread != null)
            {
                DirectInputThread.Abort();
            }
            DirectInputDeviceList.Items.Clear();
            dBroker = new DirectInputBroker();
            LoadDirectInput();
        }
    }
}
