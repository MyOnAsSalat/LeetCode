public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> s = new HashSet<int>();      
        foreach (int val in nums){
            if (s.Contains(val)) return true;
            s.Add(val);
        }
        return false;
    }
}