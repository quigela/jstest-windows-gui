using System.Windows.Forms;
using System.Threading;

using SharpDX.DirectInput;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace jstest_windows_gui
{
    public partial class DirectInputControl : UserControl
    {

        private DirectInputBroker dBroker;
        private Thread DirectInputThread = null;
        public ManualResetEvent DirectInputThreadControl = new ManualResetEvent(true);

        private readonly Dictionary<int, string> cordMap = new Dictionary<int, string> { { 0, "X" }, { 1, "Y" }, { 2, "Z" }, { 3, "AA" },
        { 4, "BB" },{ 5, "CC" },{ 6, "DD" },{ 7, "EE" },{ 8, "FF" },{ 9, "GG" } };
        public DirectInputControl()
        {
            dBroker = new DirectInputBroker();
            InitializeComponent();
        }

        private void DirectInputControl_Load(object sender, EventArgs e)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
              BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
              null, DirectInputButtonList, new object[] { true });

            typeof(Control).InvokeMember("DoubleBuffered",
              BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
              null, DirectInputSliderList, new object[] { true });

            typeof(Control).InvokeMember("DoubleBuffered",
              BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
              null, DirectInputHatList, new object[] { true });

            typeof(Control).InvokeMember("DoubleBuffered",
              BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
              null, DirectInputCapaList, new object[] { true });
        }

        public void LoadDirectInput()
        {
            LogDirectInput("Searching DirectInput devices...");

            if (!dBroker.DevsFound())
            {
                LogDirectInput("No DirectInput devices detected.");
            }
            else
            {
                foreach (Guid g in dBroker.GetGuidList())
                {
                    DirectInputDeviceList.Items.Add(g.ToString());
                    LogDirectInput("DirectInput device found: " + g.ToString());
                }
            }

            LogDirectInput("Double-Click GUID to attach...");
        }

        private void LogDirectInput(string msg)
        {
            log_DirectInput.AppendText(msg + "\n");
            log_DirectInput.SelectionStart = log_DirectInput.TextLength;
            log_DirectInput.ScrollToCaret();
        }

        private void DirectInputInterval()
        {

            Joystick joystick = dBroker.GetInstance();

            while (true)
            {
                DirectInputThreadControl.WaitOne();
                //Console.WriteLine("poll DirectInput");

                try
                {
                    joystick.Poll();
                    JoystickState state = joystick.GetCurrentState();

                    this.Invoke((MethodInvoker)delegate
                    {
                        
                        //button list refresh
                        UpdateButtons(state);
                        UpdateSliders(state);
                        UpdateHat(state);
                    });
                }
                catch (Exception ex) when (ex is SharpDX.SharpDXException || ex is System.NullReferenceException)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        LogDirectInput("Connection lost!");
                        dBroker.VoidInstance();
                        AbortDInput();
                    });
                }
                Thread.Sleep(50);
            }
        }

        private void UpdateHat(JoystickState state)
        {
            for (int i = 0; i < 4; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(state.PointOfViewControllers.GetValue(i).ToString());
                if (DirectInputHatList.Items.Count <= (i + 1))
                {
                    DirectInputHatList.Items.Add(item);
                }
                else
                {
                    DirectInputHatList.Items[i] = item;
                }
            }
        }

        private void UpdateButtons(JoystickState state)
        {
            DirectInputButtonList.BeginUpdate();

            for (int i = 0; i < state.Buttons.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(state.Buttons[i].ToString());
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
        }

        private void UpdateSliders(JoystickState state)
        {
            Dictionary<string, int[]> dataMap = new Dictionary<string, int[]>
                        {
                            {"", new int[] { state.X, state.Y, state.Z } },
                            {"Rotation", new int[] { state.RotationX, state.RotationY, state.RotationZ } },
                            {"Acceleration", new int[] { state.AccelerationX, state.AccelerationY, state.AccelerationZ } },
                            {"AccelerationSliders", state.AccelerationSliders },
                            {"AngularAccel", new int[] { state.AngularAccelerationX, state.AngularAccelerationY, state.AngularAccelerationZ } },
                            {"AngularVelocity", new int[] { state.AngularVelocityX, state.AngularVelocityY, state.AngularVelocityZ } },
                            {"Torque", new int[] { state.TorqueX, state.TorqueY, state.TorqueZ } },
                            {"Force", new int[] { state.ForceX, state.ForceY, state.ForceZ } },
                            {"ForceSliders", state.ForceSliders },
                            {"Velocity", new int[] {state.VelocityX, state.VelocityY, state.VelocityZ } },
                            {"VelocitySliders", state.VelocitySliders }
                        };

            DirectInputSliderList.BeginUpdate();
            int totalCount = 0;
            foreach (KeyValuePair<string, int[]> pair in dataMap)
            {
                for (int i = 0; i < pair.Value.Length; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = pair.Key + cordMap[i];
                    item.SubItems.Add(pair.Value[i].ToString());

                    //insert or update item
                    if (DirectInputSliderList.Items.Count <= totalCount)
                    {
                        DirectInputSliderList.Items.Add(item);
                    }
                    else
                    {
                        DirectInputSliderList.Items[totalCount] = item;
                    }
                    totalCount++;
                }
            }
            DirectInputSliderList.EndUpdate();
        }

        private void DirectInputDeviceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.DirectInputDeviceList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                AbortDInput();
                ClearDInputData();
                Guid guid = Guid.Parse(DirectInputDeviceList.Items[index].ToString());
                LogDirectInput("Attaching to DirectInput device: " + guid.ToString());
                if (dBroker.CreateInstance(guid))
                {
                    DirectInputDiscoverCapabilities();
                    DirectInputThread = new Thread(DirectInputInterval);
                    DirectInputThread.Start();
                }
                else
                {
                    LogDirectInput("Unable to attach!");
                }

            }
        }

        private void DirectInputDeviceList_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Button.ToString());
            if (e.Button == MouseButtons.Right)
            {
                AbortDInput();
                ClearDInputData();
                dBroker.VoidInstance();
                LogDirectInput("Detached!");
            }
        }

        private void DirectInputDiscoverCapabilities()
        {
            //if (dBroker.getInstance() == null) return;

            SharpDX.DirectInput.Capabilities caps = dBroker.GetInstance().Capabilities;
            Dictionary<string, string> capDict = new Dictionary<string, string>
            {
                {"POV Count",  caps.PovCount.ToString()},
                {"Axe Count",  caps.AxeCount.ToString()},
                {"Button Count",  caps.ButtonCount.ToString()},
                {"Flags",  caps.Flags.ToString()},
                {"Type",  caps.Type.ToString()},
                {"Subtype",  caps.Subtype.ToString()},
                {"Driver Version",  caps.DriverVersion.ToString()},
                {"Hardware Revision",  caps.HardwareRevision.ToString()},
                {"Firmware Revision",  caps.FirmwareRevision.ToString()},
            };

            int totalCount = 0;
            foreach (KeyValuePair<string, string> pair in capDict)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pair.Key;
                item.SubItems.Add(pair.Value.ToString());

                if (DirectInputCapaList.Items.Count <= totalCount)
                {
                    DirectInputCapaList.Items.Add(item);
                }
                else
                {
                    DirectInputCapaList.Items[totalCount] = item;
                }
                totalCount++;
            }
        }

        private void DirectInputReset_Click(object sender, EventArgs e)
        {
            AbortDInput();
            ClearDInputData();
            DirectInputDeviceList.Items.Clear();
            dBroker = new DirectInputBroker();
            LoadDirectInput();
        }

        private void ClearDInputData()
        {
            DirectInputHatValue.Text = "";
            DirectInputSliderList.Items.Clear();
            DirectInputButtonList.Items.Clear();
            DirectInputCapaList.Items.Clear();
            DirectInputHatList.Items.Clear();
        }

        public void AbortDInput()
        {
            if (this.DirectInputThread != null) { DirectInputThread.Abort(); }
        }
    }
}
