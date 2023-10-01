public class Solution {
public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string,IList<string>>();
        for(int i = 0; i < strs.Length; i++)
        {
            var strArray = strs[i].ToArray();
            Array.Sort(strArray);
            var hash = new string(strArray);
            if(dict.ContainsKey(hash))
            {
               var val = dict.GetValueOrDefault(hash);
               val.Add(strs[i]);
            }
            else
            {
                dict.Add(hash,new List<string>{strs[i]});
            }
        }    
        return dict.Values.ToList();
    }
}