public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)return false;
        Dictionary<char,int>dts=new();
        Dictionary<char,int>dtt=new();
        for(int i=0;i<s.Length;i++)
        {
            if(dts.ContainsKey(s[i]))
            {
                dts[s[i]]++;
            }
            else{
                dts[s[i]]=1;
            }
            if(dtt.ContainsKey(t[i]))
            {
                dtt[t[i]]++;
            }
            else{
                dtt[t[i]]=1;
            }
        }
        foreach(char c in s)
        {
           if(!dtt.ContainsKey(c))return false;
           if( dts[c]!=dtt[c])return false;
        }
        return true;

    }
}
