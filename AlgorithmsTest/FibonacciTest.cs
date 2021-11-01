using System.Collections.Generic;
using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class FibonacciTest
    {
        [Fact]
        public void TestCanGetFibonacciNumber()
        {
            Assert.Equal(1,Fibonacci.Fib(1, new Dictionary<int, long>()));
            Assert.Equal(1,Fibonacci.Fib(2, new Dictionary<int, long>()));
            Assert.Equal(2,Fibonacci.Fib(3, new Dictionary<int, long>()));
            Assert.Equal(3,Fibonacci.Fib(4, new Dictionary<int, long>()));
            Assert.Equal(5,Fibonacci.Fib(5, new Dictionary<int, long>()));
            Assert.Equal(8,Fibonacci.Fib(6, new Dictionary<int, long>()));
            Assert.Equal(13,Fibonacci.Fib(7, new Dictionary<int, long>()));
            Assert.Equal(21,Fibonacci.Fib(8, new Dictionary<int, long>()));
            Assert.Equal(12586269025,Fibonacci.Fib(50, new Dictionary<int, long>()));
        }
    }
}