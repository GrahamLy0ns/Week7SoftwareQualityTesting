using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Week7SoftwareQualityTesting;

namespace ConsoleApp1
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public static void Add_TwoPostitiveNums_PositiveNum()
        {

            Calculator c = new Calculator();
            int actualResult = c.Add(2, 3);
            Assert.That(actualResult, Is.EqualTo(5));

        }
        [TestCase(5,5,ExpectedResult = 10)]
        public static int Add_TowNegative_NegativveNum()
        {
            Calculator c = new Calculator();
            int actualResults = c.Add(-2, -3);
            return actualResults;
        }
    }
}
