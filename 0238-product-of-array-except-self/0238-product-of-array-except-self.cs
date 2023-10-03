public class Solution {
public int[] ProductExceptSelf(int[] nums) {
        bool zeroExist = false;
        var pref = 1;
        var post = 1;
        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                if (zeroExist)
                {
                    return new int[nums.Length];
                }
                zeroExist = true;
            }
            result[i] = pref;
            pref *= nums[i];
        }
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= post;
            post *= nums[i];
        }
        return result;
    }
}