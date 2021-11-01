using System;
using System.Linq;

namespace Algorithms
{
    public class BubbleSort
    {
        public int[] Sort(int[] numbers)
        {
            var length = numbers.Length-1;
            for (var j = 0; j < length; j++)
            for (var i = 0; i < length-j; i++)
                if (numbers[i] > numbers[i+1])
                    (numbers[i], numbers[i + 1]) = (numbers[i + 1], numbers[i]);

            return numbers;
        }
    }
}