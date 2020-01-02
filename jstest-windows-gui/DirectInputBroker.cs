using System;
using System.Collections;
using SharpDX.DirectInput;

namespace jstest_windows_gui
{
    class DirectInputBroker
    {
        private DirectInput directInput = new DirectInput();
        private ArrayList joystickGuids = new ArrayList();
        private Joystick joystick = null;
        public const int BUFSIZE = 128; 
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
        public bool createInstance(Guid guid)
        {
            try
            {
                if (this.joystick != null)
                {
                    this.joystick.Unacquire();
                    this.joystick = null;
                }
                this.joystick = new Joystick(directInput, guid);

                joystick.Properties.BufferSize = DirectInputBroker.BUFSIZE;

                joystick.Acquire();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void voidInstance()
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

        public Joystick getInstance()
        {
            return joystick;
        }

        public int getGuidCount()
        {
            return joystickGuids.Count;
        }
        public bool devsFound()
        {
            return (joystickGuids.Count > 0);
        }

        public ArrayList getGuidList()
        {
            return joystickGuids;
        }
    }
}
