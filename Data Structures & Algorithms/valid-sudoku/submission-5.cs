public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, bool> row = new Dictionary<int, bool>();
        Dictionary<int, bool> col = new Dictionary<int, bool>();
        List<Dictionary<int, bool>> box = new List<Dictionary<int, bool>>();
        for (int i = 0; i < 9; i++) {
            box.Add(new Dictionary<int, bool>());
        }
        int boxIndex = 0;
        for ( int i = 0 ; i < 9 ; i++) {
            row.Clear();
            col.Clear();
            for (int j = 0 ; j<9 ; j++) {
                boxIndex = ((i/3)*3) + (j/3);
                if (board[i][j] != '.') {
                    int val = board[i][j];
                    if (row.ContainsKey(val))
                        return false;
                    else row.Add(val, true);
                }
                if (board[j][i] != '.') {
                    int val = board[j][i];
                    if (col.ContainsKey(val))
                        return false;
                    else col.Add(val, true);
                }
                if (board[i][j] != '.') {
                    int val = board[i][j];
                    if (box[boxIndex].ContainsKey(val))
                        return false;
                    else box[boxIndex].Add(val, true);
                }
            }
        }
        return true;
    }
}