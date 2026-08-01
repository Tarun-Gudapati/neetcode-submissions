public class Solution {
    public int AppendCharacters(string s, string t) {
        int seq=t.Length;
        int m=0;
        foreach(char i in s)
        {
            if(m<seq && i==t[m])
            {
                m++;
            }
        }
        return seq-m;
    }
}