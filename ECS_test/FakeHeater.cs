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
        public int turnOnCounter;
        public int turnOffCounter;
        public int selfTestCounter;

        public void TurnOn()
        {
            turnOnCounter++;
        }

        public void TurnOff()
        {
            turnOffCounter++;
        }

        public bool RunSelfTest()
        {
            selfTestCounter++;
            return true;
        }
    }
}
