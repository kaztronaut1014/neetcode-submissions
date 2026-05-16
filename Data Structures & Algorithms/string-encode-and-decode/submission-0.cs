public class Solution {

    public string Encode(IList<string> strs) {
        string encodedString = "";
        foreach (var str in strs) {
            encodedString += str.Length + "#" + str;
        }
        return encodedString;
    }

    public List<string> Decode(string s) {
        List<string> decodedStrings = new List<string>();
        int i = 0;
        while (i<s.Length)
        {
            int j = s.IndexOf("#", i);
            int length = int.Parse(s.Substring(i, j - i));
            decodedStrings.Add(s.Substring(j + 1, length));
            i = j + length + 1;
        }
        return decodedStrings;
    }
}
