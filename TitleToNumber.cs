public class Solution {
    public int TitleToNumber(string columnTitle) {

        int res = 0;
        int l = columnTitle.Length - 1;

        for(int i=0; i <= l; i++) {
            int temp = (int)Math.Pow(26, (l-i)) * (columnTitle[i] - 64);

            res += temp;
        }
        return res;
    }

    public int TitleToNumber(string columnTitle) {

        
    }
}