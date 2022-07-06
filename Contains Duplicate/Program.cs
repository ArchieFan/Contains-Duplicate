public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        int l = 0;
        int r = 1;
        while (l < nums.Length - 1)
        {
            if (nums[l] == nums[r]) return true;
            r++;
            if (r > nums.Length - 1)
            {
                l++;
                r = l + 1;
            }  
        }
        return false;
    }

    public bool ContainsDuplicate2(int[] nums)
    {
        // insert the array to Hashset if handset count lesser than arry lenght means contain duplicate
        return new HashSet<int>(nums).Count < nums.Length;
        // return new HashSet<int>(nums).Count != nums.Length;
    }

    public bool ContainsDuplicate3(int[] nums)
    {
        var set = new HashSet<int>();
        return nums.Any(x => !set.Add(x));
    }

    public bool ContainsDuplicate4(int[] nums)
    {
        var hash = new HashSet<int>();
        foreach (var item in nums)
            if (!hash.Add(item)) return true;
        return false;
    }


    static void Main()
    {
        //int[] nums = { 1, 2, 3, 1 };
        //int[] nums = { 1,2,3,4 };
        int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        Solution solution = new Solution();
        bool res = solution.ContainsDuplicate(nums);
        Console.WriteLine(res);
    }
}