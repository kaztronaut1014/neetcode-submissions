public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // Dùng Dictionary để gom nhóm
        // Key: Chuỗi đã sắp xếp (ví dụ: "act")
        // Value: Danh sách các từ gốc (ví dụ: ["act", "cat"])
        var groups = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            // 1. Chuyển chuỗi thành mảng char để sắp xếp
            char[] characters = s.ToCharArray();
            Array.Sort(characters);
            
            // 2. Tạo Key từ mảng đã sắp xếp
            string key = new string(characters);

            // 3. Nếu chưa có Key này thì tạo List mới
            if (!groups.ContainsKey(key)) {
                groups[key] = new List<string>();
            }

            // 4. Thêm từ gốc vào nhóm của Key đó
            groups[key].Add(s);
        }

        // Trả về tất cả các Value (danh sách các nhóm)
        return groups.Values.Cast<List<string>>().ToList();
    }
}