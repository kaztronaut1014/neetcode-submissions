public class Solution {
    public bool IsPalindrome(string s) {
        
        s = s.Replace(" ", "");
        s = s.Replace("?", "");
        s = s.Replace("!", "");
        s = s.Replace(".", "");
        s = s.Replace(",", "");
        s = s.Replace(":", "");
        s = s.Replace(";", "");
        s = s.Replace("'", "");
        s = s.Replace("\"", "");


        int len = s.Length;
        s = s.ToUpper();

        if (len == 0)
            return true;

        for (int i = 0 ; i<len/2 ; i++)
        {
            int ptr1 = i;
            int ptr2 = len-1-ptr1;
            if (s[ptr1] != s[ptr2])
                return false;
        }
        return true;
    }
}
