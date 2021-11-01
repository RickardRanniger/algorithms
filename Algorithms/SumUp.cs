using System.Linq;

namespace Algorithms
{
    public class SumUp
    {
        public static bool DoesItSomeUp(int target, int[] numbers)
        {
            return target switch
            {
                0 => true,
                < 0 => false,
                _ => numbers.Select(number => target - number).Any(remainder => DoesItSomeUp(remainder, numbers))
            };
        } 
    }
}