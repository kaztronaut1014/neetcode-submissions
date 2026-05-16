public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }
        var sortedDict = frequencyMap.OrderByDescending(x => x.Value);
        return sortedDict.Take(k).Select(x => x.Key).ToArray();
    }
}
