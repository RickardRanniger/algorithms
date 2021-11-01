using System.Collections.Generic;
using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class TravelGridTest
    {
        [Fact]
        public void TestCanTravelGrid()
        {
            var travelGrid = new TravelGrid();
            var memo = new Dictionary<(int, int), long>();
            Assert.Equal(1, travelGrid.calc(9, 9, memo));
            // Assert.Equal(3, travelGrid.calc(3, 2, memo));
            // Assert.Equal(3, travelGrid.calc(2, 3, memo));
            // Assert.Equal(6, travelGrid.calc(3, 3, memo));
            // Assert.Equal(20, travelGrid.calc(4, 4, memo));
            // Assert.Equal(70, travelGrid.calc(5, 5, memo));
            // Assert.Equal(252, travelGrid.calc(6, 6, memo));
            // Assert.Equal(252, travelGrid.calc(1000, 1000, memo));
        }
    }
}