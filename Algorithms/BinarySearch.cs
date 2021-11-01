namespace Algorithms
{
    public class BinarySearch
    {
        public int Search(int[] numbers, int left, int right, int target)
        {
            if (left > right)
                return -1;

            var mid = (left + right) / 2;

            if (target == numbers[mid])
                return mid;

            return target < numbers[mid]
                ? Search(numbers, left, mid - 1, target)
                : Search(numbers, mid + 1, right, target);
        }
    }
}