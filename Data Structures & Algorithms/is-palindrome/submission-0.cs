public class Solution {
    public bool IsPalindrome(string s) {
        s=Regex.Replace(s,"[^a-zA-Z0-9]","").ToLower();
        int len=s.Length;
        int end=len-1;
        for(int i=0;i<len/2;i++)
        {
            if(s[i]!=s[end-i])
            return false;
        }
        return true;

    }
}
