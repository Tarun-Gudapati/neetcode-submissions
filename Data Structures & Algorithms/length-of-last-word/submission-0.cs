public class Solution {
    public int LengthOfLastWord(string s) {

        int last=s.Length-1;
     
        int lastword=0;
        bool shouldStart=false;
        for(int i=last;i>=0;i--)
        {
            if(s[i]!=' ')shouldStart=true;
            
            if(s[i]==' ' && shouldStart)
            break;
            if(shouldStart)
            lastword++;
        }
        return lastword;
    }
}