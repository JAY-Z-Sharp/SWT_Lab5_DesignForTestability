using NUnit.Framework;
//using ECS = ECS.Legacy_Refactored.ECS;


namespace ECS_test
{
    public class Tests
    {

        private ECS.Legacy_Refactored.ECS testECS;
        private FakeTempSensor testTempSensor;
        private FakeHeater testHeater;

        [SetUp]
        public void Setup()
        {
            //testECS = new ECS.Legacy_Refactored.ECS(23, new FakeTempSensor(), new FakeHeater());
            FakeTempSensor testTempSensor = new FakeTempSensor();
            FakeHeater testHeater = new FakeHeater();
        }

    
  
        [TestCase(20, 40, 3)]

        public void regulate_turnOff_returnAmountOfCalls(int thres, int temp, int result)
        {
            //act

            testECS = new ECS.Legacy_Refactored.ECS(thres, testTempSensor, testHeater);

            testTempSensor.setTemp(temp);

            for (int i = 0; i < result; i++)
            {
                testECS.Regulate();
            }
            
            //Assert
            Assert.That(testHeater.TurnOffCounter, Is.EqualTo(result));
        }
    }
}