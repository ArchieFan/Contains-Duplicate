namespace Contains_Duplicate.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1  }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void Test1(int[] nums, bool expected)
        {
            Solution solution = new Solution();
            bool res = solution.ContainsDuplicate(nums);
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void Test2(int[] nums, bool expected)
        {
            Solution solution = new Solution();
            bool res = solution.ContainsDuplicate2(nums);
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void Test3(int[] nums, bool expected)
        {
            Solution solution = new Solution();
            bool res = solution.ContainsDuplicate3(nums);
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void Test4(int[] nums, bool expected)
        {
            Solution solution = new Solution();
            bool res = solution.ContainsDuplicate4(nums);
            Assert.Equal(expected, res);
        }
    }
}