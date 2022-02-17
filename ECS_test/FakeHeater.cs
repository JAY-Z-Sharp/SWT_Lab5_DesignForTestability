using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy_Refactored;

namespace ECS_test
{
    public class FakeHeater : IHeater
    {
        public int TurnOnCounter { get; set; }
        public int TurnOffCounter { get; set; }
        public int SelfTestCounter { get; set; }

        public void TurnOn()
        {
            TurnOnCounter++;
        }

        public void TurnOff()
        {
            TurnOffCounter++;
        }

        public bool RunSelfTest()
        {
            SelfTestCounter++;
            return true;
        }
    }
}
