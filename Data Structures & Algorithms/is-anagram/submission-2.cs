public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict = new Dictionary<char,int>();
        foreach (char c in s) {
            if (dict.ContainsKey(c))
                dict[c]++;
            else dict[c] = 1;
        }
        foreach (char c in t) {
            if (dict.ContainsKey(c)) {
                dict[c]--;
                if (dict[c]<0)
                    return false;
            }
            else return false;
        }

        if (dict.Values.Any(v => v != 0))
        {
            return false;
        }
        
        return true;
    }
}
