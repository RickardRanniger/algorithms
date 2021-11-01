using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class SumUpTest
    {
        [Fact]
        public void Test()
        {
            Assert.True(SumUp.DoesItSomeUp(10,new []{2}));
            Assert.True(SumUp.DoesItSomeUp(100,new []{8,3}));
            Assert.False(SumUp.DoesItSomeUp(10,new []{3})); 
        }
    }
}