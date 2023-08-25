namespace LeetCodeSolutions;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 2};
        int[] nums2 = { 3,4 };
        Solution solution = new Solution();
        Console.WriteLine(solution.FindMedianSortedArrays(nums1, nums2));
    }
}

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            list.Add(nums1[i]);
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            list.Add(nums2[i]);
        }
        list.Sort();

        if (list.Count() % 2 == 0)
        {
            int x = list[(int)((list.Count() / 2.0))];
            int y = list[(int)(Math.Ceiling(list.Count() / 2.0))];
            return (list[(int)(Math.Floor(list.Count() / 2.0)) - 1] + list[(int)(Math.Ceiling(list.Count() / 2.0))]) / 2.0;
        }
        else
        {
            return list[(int)(Math.Floor(list.Count() / 2.0))];
        }

        

    }
}