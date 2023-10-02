public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, IList<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            char[] hash = new char[26];
            foreach (char ch in strs[i])
            {
                hash[ch - 'a']++;
            }
            var k = new string(hash);
            if (!dict.ContainsKey(k))
            {
                dict[k] = new List<string>();
            }
            dict[k].Add(strs[i]);
        }
        return dict.Values.ToList();
    }
}