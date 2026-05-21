public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> arr = new HashSet<int>(nums);
        int longest = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (!arr.Contains(nums[i] - 1)) {
                int currentNum = nums[i];
                int currentStreak = 1;
                while (arr.Contains(currentNum + 1)) {
                    currentNum += 1;
                    currentStreak += 1;
                }
                longest = Math.Max(longest, currentStreak);
            }
        }
        return longest;
    }
}
