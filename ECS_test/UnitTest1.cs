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

        [TestCase(10, 0)]
        [TestCase(1000, 0)]
        [TestCase(-9, 0)]

        public void divide_divideByZero_returnThrows(int a, int b)
        {
            //Assert
            Assert.That(() => testCalc.Divide(a, b), Throws.TypeOf<DivideByZeroException>());
        }
    }
}