public class Solution {
    public int ScoreOfString(string s) {
        int sum=0;
        if(s.Length<2)return sum;
       // if(s.Length<2)return (int)s[0];
        for(int i=1;i<s.Length;i++)
        {
            int a=s[i-1];
            int b=s[i];
            sum+=Math.Abs(a-b);
        }
        return sum;
    }
}