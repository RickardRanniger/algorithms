using System.Diagnostics;
using Algorithms;
using Xunit;
using Xunit.Abstractions;

namespace AlgorithmsTest
{
    public class BinarySearchTest
    {
        private ITestOutputHelper outputHelper;
        private Stopwatch _stopwatch;
        

        public BinarySearchTest(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
            this._stopwatch = new Stopwatch();
        }

        [Fact]
        public void CanSearch()
        {
            var binarySearch = new BinarySearch();
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,20,21};
            this._stopwatch.Start();
            var result = binarySearch.Search(numbers, 0, numbers.Length - 1, 15);
            this._stopwatch.Stop();
            outputHelper.WriteLine(_stopwatch.ElapsedTicks.ToString());
            Assert.Equal(15, numbers[result]);
        }
    }
}