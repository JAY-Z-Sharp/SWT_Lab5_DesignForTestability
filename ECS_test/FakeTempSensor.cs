using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy_Refactored;

namespace ECS_test
{
    public class FakeTempSensor : ITempSensor
    {
     
        private Random gen = new Random();

        public int GetTempNumber = 0;
        public int RunSelfTestNumber = 0;

        public int GetTemp()
        {
            
            return ++GetTempNumber;
        }

        public bool RunSelfTest()
        {
            ++RunSelfTestNumber;
            return true ;
        }
    }
}
