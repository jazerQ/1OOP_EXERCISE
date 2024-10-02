
namespace Fraction_1_exercise_OOP.nUnitTests
{
    public class FractionsTest
    {
        private Fractions _Frac { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        [TestCase(1, 5.73, 6.73)]
        [TestCase(-84, -5.73, -89.73)]
        [TestCase(8, -0.9, -8.9)]
        public void Test1(int a, double b, double expected)
        {
            Fractions num = new Fractions(a, b);
            Assert.AreEqual(expected, num.FullNum);
        }
    }
}