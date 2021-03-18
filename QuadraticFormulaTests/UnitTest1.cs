using NUnit.Framework;
using QuadraticFormulaCalculator;

namespace QuadraticFormulaTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //Test that the complex class can be instantiated and the utility function (which currently echoes back the inputs converted to complexes)
        //
        //public void Test1()
        //{
        //    var results = new Complex[3];
        //    double a = 1, b = 2, c = 3;
        //    results = Calculator.Calculate(a, b, c);
        //    Assert.IsTrue((results[0].Real == 1.0) && (results[1].Real == 2.0) && (results[2].Real == 3.0));
        //}

        //Begin tests to determine if the discriminant is calculated correctly, and the results array is populated with the correct values to indicate number and type of solutions

        [Test]
        //Test for x^2 + 10x + 24 = 0. Factors into (x + 6)(x + 4)
        //Discriminant value should be 4, so two real zeroes (-6 and -4)
        public void Test2_1()
        {
            var results = new Complex[3];
            double a = 1.0, b = 10.0, c = 24.0;
            results = Calculator.Calculate(a, b, c);
            Assert.AreEqual(results[0].Real, 0.0);
        }

        [Test]
        //Test for x^2 -2x -24. Factors into (x - 6)(x + 4)
        //Discriminant value should be 100, so two real zeroes (6 and 4)
        public void Test2_2()
        {
            var results = new Complex[3];
            double a = 1.0, b = -2.0, c = -24.0;
            results = Calculator.Calculate(a, b, c);
            Assert.AreEqual(results[0].Real, 0.0);
        }

        [Test]
        //Test for x^2 + 4x + 4. Factors into (x + 2)^2
        //Discriminant value should be zero, so one real zero (only x = -2)
        public void Test2_3()
        {
            var results = new Complex[3];
            double a = 1.0, b = 4.0, c = 4.0;
            results = Calculator.Calculate(a, b, c);
            Assert.AreEqual(results[0].Real, 1.0);
        }

        [Test]
        //Test for x^2 - 0.5x + 0.0625. Factors into  (x - 0.25)^2
        //Discriminant value should be zero, so one real zero (x = 0.25)
        public void Test2_4()
        {
            var results = new Complex[3];
            double a = 1.0, b = -0.5, c = 0.0625;
            results = Calculator.Calculate(a, b, c);
            Assert.AreEqual(results[0].Real, 1.0);
        }

        [Test]
        //Test for x^2 + 0.0x - 25.0. Factors into  (x + 5)(x - 5)
        //Discriminant value should be 100, so two real zeroes (x = +- 5)
        public void Test2_5()
        {
            var results = new Complex[3];
            double a = 1.0, b = 0.0, c = -25.0;
            results = Calculator.Calculate(a, b, c);
            Assert.AreEqual(results[0].Real, 0.0);
        }

        [Test]
        //Test for x^2 + 0.0x 25. Factors into (x + 5i)(x - 5i)
        //Discriminant value should be -100, so two complex zeroes (x = +- 5i)
        public void Test2_6()
        {
            var results = new Complex[3];
            double a = 1.0, b = 0.0, c = 25.0;
            results = Calculator.Calculate(a, b, c);
            Assert.AreEqual(results[0].Real, 2.0);
        }
    }
}