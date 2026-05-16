public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {   
            if (i == 0)
            {
                result[i] = 1;
            }else 
            {
                result[i] = nums[i-1] * result[i - 1];
            }
        }
        int rightProduct = 1;
        for (int j = nums.Length - 1; j >= 0; j--)
        {
            result[j] *= rightProduct;
            rightProduct *= nums[j];
        }
        return result;
    }
}
