using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingLib.Math;

namespace UnitTesting
{
    public class PrimeCalcTest
    {
        private readonly BasicCalc _calculator;

        public PrimeCalcTest()
        {
            _calculator = new BasicCalc();
        }

        [Fact]
        public void Prime_ShouldReturnCorrect()
        {
            bool result = _calculator.IsPrime(7);
            Assert.True(result);
        }

        [Fact]
        public void Prime_ShouldThrowExpection()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.IsPrime(-1));
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(53, true)]
        [InlineData(0, false)]

        public void Prime_Theory(int a, bool expectedResult)
        {
            bool result = _calculator.IsPrime(a);
            Assert.Equal(expectedResult, result);
        }


    }
}
