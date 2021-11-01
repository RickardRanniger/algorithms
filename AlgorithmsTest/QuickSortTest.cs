using System;
using Algorithms;
using Xunit;
using Xunit.Abstractions;

namespace AlgorithmsTest
{
    public class QuickSortTest
    {
        private readonly ITestOutputHelper _outputHelper;

        public QuickSortTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        private int Recursive(int[] values, int index)
        {
            if (index == values.Length-1)
            {
                //_outputHelper.WriteLine("Last element");
                return values[index];
            }

            return Recursive(values, index + 1) + values[index];
        }
        
        [Fact]
        public void TestCanQuickSort()
        {
            _outputHelper.WriteLine("Start ");

            var values = new int[] {5, 4, 1, 2, 9, 7, 8, 6, 3};

            _outputHelper.WriteLine(Recursive(values, 0).ToString());

            // var quickSort = new QuickSort();
            // Assert.Equal(quickSort.Sort(
            //         new int[] {5, 4, 1, 2, 9, 7, 8, 6, 3}),
            //     new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9});
        }
    }
}