using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

using SharpDX.XInput;
using System.Reflection;

namespace jstest_windows_gui
{
    public partial class XInputControl : UserControl
    {

        private XInputBroker xBroker;
        private Thread XInputThread = null;
        public ManualResetEvent XInputThreadControl = new ManualResetEvent(true);
        public XInputControl()
        {
            xBroker = new XInputBroker();
            InitializeComponent();
        }

        private void XInputControl_Load(object sender, EventArgs e)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, XInputButtonList, new object[] { true });

            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, XInputHatList, new object[] { true });

            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, XInputInfoList, new object[] { true });
        }

        public void LoadXInput()
        {
            LogXInput("Adding XInput devices...");

            XInputDeviceList.Items.AddRange(xBroker.getDevices().ToArray());

            LogXInput("Double-Click Player to connect...");
        }

        private void LogXInput(string msg)
        {
            log_XInput.AppendText(msg + "\n");
            log_XInput.SelectionStart = log_XInput.TextLength;
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
                    abortXInput();
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

                        updateButtonList(state);
                        updateHatList(state);
                        updateInfo(c);
                    });

                previousState = state;
                Thread.Sleep(50);
            }
        }

        private void updateInfo(Controller c)
        {
            BatteryInformation gamepadBattery = c.GetBatteryInformation(BatteryDeviceType.Gamepad);
            BatteryInformation headsetBattery = c.GetBatteryInformation(BatteryDeviceType.Headset);

            Capabilities gamepadCapa = c.GetCapabilities(DeviceQueryType.Gamepad);
            Vibration v = gamepadCapa.Vibration;
            string vibeString = "L: " + (v.LeftMotorSpeed == 255).ToString() + "  |  R: " + (v.RightMotorSpeed == 255).ToString();

            Dictionary<string, string> infoDict = new Dictionary<string, string>
            {
                { "GamepadBatteryType", gamepadBattery.BatteryType.ToString()},
                { "GamepadBatteryLevel", gamepadBattery.BatteryLevel.ToString()},
                { "HeadsetBatteryType", headsetBattery.BatteryType.ToString()},
                { "HeadsetBatteryLevel", headsetBattery.BatteryLevel.ToString()},
                { "GamepadFlags", gamepadCapa.Flags.ToString()},
                { "GamepadType", gamepadCapa.Type.ToString()},
                { "GamepadSubType", gamepadCapa.SubType.ToString()},
                { "Vibration", vibeString},
            };

            int totalCount = 0;
            XInputInfoList.BeginUpdate();
            foreach (KeyValuePair<string, string> pair in infoDict)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pair.Key.ToString();
                item.SubItems.Add(pair.Value);

                if (XInputInfoList.Items.Count <= (totalCount))
                {
                    XInputInfoList.Items.Add(item);
                }
                else
                {
                    XInputInfoList.Items[totalCount] = item;
                }
                totalCount++;
            }
            XInputInfoList.EndUpdate();
        }

        private void updateButtonList(State state)
        {
            Dictionary<int, string> buttonList = new Dictionary<int, string>
            {
                {0, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.A).ToString()},
                {1, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.B).ToString()},
                {2, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.X).ToString()},
                {3, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.Y).ToString()},
                {4, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.LeftShoulder).ToString()},
                {5, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.RightShoulder).ToString()},
                {6, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.Back).ToString()},
                {7, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.Start).ToString()},
                {8, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.LeftThumb).ToString()},
                {9, (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.RightThumb).ToString()}
            };

            int totalCount = 0;
            XInputButtonList.BeginUpdate();
            foreach(KeyValuePair<int, string> pair in buttonList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pair.Key.ToString();
                item.SubItems.Add(pair.Value);

                if (XInputButtonList.Items.Count <= (totalCount))
                {
                    XInputButtonList.Items.Add(item);
                }
                else
                {
                    XInputButtonList.Items[totalCount] = item;
                }
                totalCount++;
            }
            XInputButtonList.EndUpdate();
        }

        private void updateHatList(State state)
        {
            Dictionary<string, string> hatList = new Dictionary<string, string>
            {
                {"Up",  (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.DPadUp).ToString()},
                {"Down", (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.DPadDown).ToString()},
                {"Left", (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.DPadLeft).ToString()},
                {"Right", (state.Gamepad.Buttons & SharpDX.XInput.GamepadButtonFlags.DPadRight).ToString()},
            };

            int totalCount = 0;
            XInputHatList.BeginUpdate();
            foreach (KeyValuePair<string, string> pair in hatList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pair.Key;
                item.SubItems.Add(pair.Value);

                if (XInputHatList.Items.Count <= (totalCount))
                {
                    XInputHatList.Items.Add(item);
                }
                else
                {
                    XInputHatList.Items[totalCount] = item;
                }
                totalCount++;
            }
            XInputHatList.EndUpdate();
        }

        private void XInputDeviceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.XInputDeviceList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                abortXInput();
                UserIndex controllerIndex;
                XInputBroker.IndexMap.TryGetValue(XInputDeviceList.Items[index].ToString(), out controllerIndex);
                LogXInput("Attaching to XInput controller: " + XInputDeviceList.Items[index].ToString());

                if (xBroker.selectController(controllerIndex))
                {
                    LogXInput("Attached to " + controllerIndex.ToString() + "!");
                    XInputCurrentIndexValue.Text = xBroker.getLastUsedIndex().ToString();

                    XInputLeftVibration.Enabled = true;
                    XInputRightVibration.Enabled = true;

                    XInputThread = new Thread(XInputInterval);
                    XInputThread.Start();
                }
                else
                {
                    XInputCurrentIndexValue.Text = "";
                    LogXInput("XInput controller " + controllerIndex.ToString() + " is not available");
                }
            }
        }

        public void abortXInput()
        {
            if (this.XInputThread != null) { XInputThread.Abort(); }
            XInputLeftVibration.Enabled = false;
            XInputLeftVibration.Value = 0;

            XInputRightVibration.Enabled = false;
            XInputRightVibration.Value = 0;
        }

        private void XInputLeftVibration_ValueChanged(object sender, EventArgs e)
        {
            XInputLeftVibrationValue.Text = XInputLeftVibration.Value.ToString();
            setVibration((ushort) XInputLeftVibration.Value, (ushort) XInputRightVibration.Value);
        }

        private void XInputRightVibration_ValueChanged(object sender, EventArgs e)
        {
            XInputRightVibrationValue.Text = XInputRightVibration.Value.ToString();
            setVibration((ushort) XInputLeftVibration.Value, (ushort) XInputRightVibration.Value);
        }

        private void setVibration(ushort left, ushort right)
        {
            Controller c = xBroker.getSelectedController();
            if (c.IsConnected)
            {
                Vibration v = new Vibration();
                v.LeftMotorSpeed = left;
                v.RightMotorSpeed = right;
                c.SetVibration(v);
            }
        }
    }
}
