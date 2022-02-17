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
        public void setTemp(int temp)
        {
            Temperature = temp;
        }
        
        private Random gen = new Random();

        public int GetTempNumber = 0;
        private int Temperature = 0;
        public int RunSelfTestNumber = 0;

        public int GetTemp()
        {
            ++GetTempNumber;
            return Temperature;
        }

        public bool RunSelfTest()
        {
            ++RunSelfTestNumber;
            return true ;
        }
    }
}
