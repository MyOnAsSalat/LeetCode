public class Solution {
public int[] TopKFrequent(int[] nums, int k) {
               var dict = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (!dict.ContainsKey(item))
            {
                dict[item] = 0;
            }
            dict[item]++;
        }
        var dictList = dict.ToList();
        dictList.Sort((pair1,pair2) => pair2.Value.CompareTo(pair1.Value));
        var result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = dictList[i].Key;
        }
        return result;
    }
}