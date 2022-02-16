using System;

namespace ECS.Legacy_Refactored
{
    public class ECS
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor; 
        private readonly IHeater _heater; 

        public ECS(int thr, ITempSensor temps, IHeater heat)
        {
            SetThreshold(thr);
            _tempSensor = temps;
            _heater = heat;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp(); // Brug interface
            Console.WriteLine($"Temperatur measured was {t}");
            if (t < _threshold)
                _heater.TurnOn(); // Brug interface
            else
                _heater.TurnOff(); // Brug interface

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp(); // Brug interface
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest(); // Brug interface
        }
    }
}
