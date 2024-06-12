namespace Assignment_6._2._2
{
    class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];

            int leftProduct = 1;
            for (int i = 0; i < n; i++)
            {
                result[i] = leftProduct;
                leftProduct *= nums[i];
            }

            int rightProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= rightProduct;
                rightProduct *= nums[i];
            }

            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            Solution solution = new Solution();

            int[] nums1 = { 1, 2, 3, 4 };
            int[] result1 = solution.ProductExceptSelf(nums1);
            Console.WriteLine(string.Join(", ", result1)); // Output: 24, 12, 8, 6

            int[] nums2 = { -1, 1, 0, -3, 3 };
            int[] result2 = solution.ProductExceptSelf(nums2);
            Console.WriteLine(string.Join(", ", result2)); // Output: 0, 0, 9, 0, 0
        }
    }
}