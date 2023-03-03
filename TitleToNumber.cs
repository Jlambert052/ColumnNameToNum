public class Solution {
    public int TitleToNumber(string columnTitle) {

        int res = 0;
        int l = columnTitle.Length - 1;

        for(int i=0; i <= l; i++) {
            int temp = (int)Math.Pow(26, (l-i)) * (columnTitle[i] - 64);

            res += temp;
        }
        System.Console.WriteLine($"{columnTitle} translates to the number {res}");
        return res;
    }

    public int TitleToNum2(string columnTitle) {
        char[] alphabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            int TitleLength = columnTitle.Length - 1;
            int index = 0;
            int sum = 0;

            while(TitleLength >= 0) {
                char currentChar = columnTitle[index];
                int multiple =  Array.FindIndex(alphabet, alphaChar => alphaChar == currentChar);
                sum += (int)Math.Pow(26, TitleLength) * multiple;
                TitleLength--;
                index++;
            }
            return sum;
    }
}