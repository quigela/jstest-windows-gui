using System;
using System.Collections;
using SharpDX.DirectInput;

namespace jstest_windows_gui
{
    class DirectInputBroker
    {
        private readonly DirectInput directInput = new DirectInput();
        private readonly ArrayList joystickGuids = new ArrayList();
        private Joystick joystick = null;
        private int BUFSIZE { get; set; } = 128; 
        public DirectInputBroker()
        {
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                this.joystickGuids.Add(deviceInstance.InstanceGuid);
            }
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
            {
                this.joystickGuids.Add(deviceInstance.InstanceGuid);
            }
        }

        public bool CreateInstance(Guid guid)
        {
            try
            {
                if (this.joystick != null)
                {
                    this.joystick.Unacquire();
                    this.joystick = null;
                }
                this.joystick = new Joystick(directInput, guid);

                joystick.Properties.BufferSize = BUFSIZE;

                joystick.Acquire();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void VoidInstance()
        {
            if (this.joystick != null)
            {
                try
                {
                    joystick.Unacquire();
                    joystick.Dispose();
                } catch (SharpDX.SharpDXException e)
                {
                    Console.WriteLine(e);
                }
                joystick = null;
            }
        }

        public Joystick GetInstance()
        {
            return joystick;
        }

        public int GetGuidCount()
        {
            return joystickGuids.Count;
        }
        public bool DevsFound()
        {
            return (joystickGuids.Count > 0);
        }

        public ArrayList GetGuidList()
        {
            return joystickGuids;
        }
    }
}
