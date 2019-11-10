using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{

    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        public void Add_WhenCalled_ReturnSumOfArgument()
        {         

            var result = _math.Add(4, 3);

            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]        
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expected)
        {         

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_REturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            //Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));//does not care about order
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);


        }
    }
}
