using ArithematicJenkinsDemoLibrary;
using NUnit.Framework;

namespace ArithematicDemoLobraryTest
{
    public class ArithematicTest
    {
        private Arithematic _arithematic;

        [OneTimeSetUp]
        public void Setup()
        {
            _arithematic = new Arithematic();
        }

        [TestCase(10, 20, 30)]
        [TestCase(100, 200, 300)]
        public void GivenTwoIntegers_AddThem_ResultShouldBeSum(int number1, int number2, int expectedSum)
        {
            var result = _arithematic.Add(number1, number2);

            Assert.That(result == expectedSum, $"Expected {expectedSum} as result but actual sum was {result}");
        }

        [TestCase(20, 10, 10)]
        [TestCase(200, 100, 100)]
        public void GivenTwoIntegers_SubtractThem_ResultShouldBeDifference(int number1, int number2, int expectedDifference)
        {
            var result = _arithematic.Subtract(number1, number2);

            Assert.That(result == expectedDifference, $"Expected {expectedDifference} as result but actual difference was {result}");
        }
    }
}