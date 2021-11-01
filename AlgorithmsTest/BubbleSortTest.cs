using System;
using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class BubbleSortTest
    {
        [Fact]
        public void TestCanBubbleSort()
        {
            var bubbleSort = new BubbleSort();
            Assert.Equal(bubbleSort.Sort(
                    new int[] {5, 4, 1, 2, 9, 7, 8, 6, 3}),
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9});
        }
    }
}