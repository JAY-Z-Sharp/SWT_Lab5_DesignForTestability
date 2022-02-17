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
            testTempSensor = new FakeTempSensor();
            testHeater = new FakeHeater();
        }

    
  
        [TestCase(20, 40, 3, 3)]
        [TestCase(20, 40, 10, 10)]
        [TestCase(40, 20, 0, 10)]

        public void regulate_turnOff_returnAmountOfCalls(int thres, int temp, int result, int loop)
        {
            //act

            testTempSensor.setTemp(temp);

            testECS = new ECS.Legacy_Refactored.ECS(thres, testTempSensor, testHeater);

            for (int i = 0; i < loop; i++)
            {
                testECS.Regulate();
            }
            
            //Assert
            Assert.That(testHeater.TurnOffCounter, Is.EqualTo(result));
        }
    }
}