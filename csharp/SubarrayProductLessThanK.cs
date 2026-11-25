using System;

class SubarrayProductLessThanK
{
    static int Solve(int[] nums, int k)
    {
        if (k <= 1) return 0; // every product is >= 1, nothing can be < 1

        int count = 0;
        int product = 1;
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            product *= nums[right];

            while (product >= k) // shrink until the window product is valid again
            {
                product /= nums[left];
                left++;
            }

            count += right - left + 1; // valid subarrays ending at `right`
        }
        return count;
    }

    static void Main()
    {
        Console.WriteLine(Solve(new int[] { 10, 5, 2, 6 }, 100)); // 8
        Console.WriteLine(Solve(new int[] { 1, 2, 3 }, 0));       // 0
        Console.WriteLine(Solve(new int[] { 1, 1, 1 }, 2));       // 6
    }
}
