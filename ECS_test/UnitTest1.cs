using NUnit.Framework;


namespace ECS_test
{
    public class Tests
    {

        private ECS.Legacy_Refactored.ECS testECS;

        [SetUp]
        public void Setup()
        {
            testECS = new ECS.Legacy_Refactored.ECS(23, new FakeTempSensor(), new FakeHeater());
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}