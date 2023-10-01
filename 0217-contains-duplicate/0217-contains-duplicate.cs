public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();      
        foreach (int val in nums){
            if (set.Contains(val)) return true;
            set.Add(val);
        }
        return false;
    }
}