using System;
using System.Collections;
using System.Collections.Generic;
using SharpDX.XInput;

namespace jstest_windows_gui
{
    class XInputBroker
    {
        public static readonly Dictionary<string, UserIndex> IndexMap = new Dictionary<string, UserIndex>
        {
            {"One", UserIndex.One},
            {"Two", UserIndex.Two},
            {"Three", UserIndex.Three},
            {"Four", UserIndex.Four}
        };

        //private Controller[] controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };
        private Controller selectedController = null;
        private UserIndex selectedControllerId;

        public XInputBroker()
        {
            
        }

        public bool selectController(UserIndex index)
        {
            Controller c = new Controller(index);
            if (c.IsConnected)
            {
                selectedController = c;
                selectedControllerId = index;
                return true;
            }
            else
            {
                selectedController = null;
                return false;
            }
        }

        public Controller getSelectedController()
        {
            return selectedController;
        }

        public UserIndex getLastUsedIndex()
        {
            return selectedControllerId;
        }

        public ArrayList getDevices()
        {
            ArrayList indices = new ArrayList();
            indices.Add(UserIndex.One);
            indices.Add(UserIndex.Two);
            indices.Add(UserIndex.Three);
            indices.Add(UserIndex.Four);
            return indices;
        }
    }
}
