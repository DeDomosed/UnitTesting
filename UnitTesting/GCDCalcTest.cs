using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingLib.Math;

namespace UnitTesting
{
    public class GCDCalcTest
    {
        private readonly BasicCalc _calculator;

        public GCDCalcTest()
        {
            _calculator = new BasicCalc();
        }

        [Fact]
        public void GCD_ShouldReturnCorrect()
        {
            int result = _calculator.GCD(15, 5);
            Assert.Equal(5, result);
      
        }

        [Fact]
        public void GCD_ShouldThrowExpection()
        {
            var expectionType = typeof(ArgumentOutOfRangeException);
            Assert.Throws<ArgumentOutOfRangeException>(() =>  _calculator.GCD(-1,5));
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(6, 3, 3)]
        [InlineData(15, 6, 3)]
        [InlineData(0, 6, 0)]
        [InlineData(6, 0, 0)]

        public void GCD_Theory(int a, int b, int expectedResult)
        {
            int result = _calculator.GCD(a, b);
            Assert.Equal(expectedResult, result);
        }

        
    }
}
