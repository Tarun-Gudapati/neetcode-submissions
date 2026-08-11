public class Solution {
    public int CountSeniors(string[] details) {
        int output=0;
        for(int i=0;i<details.Length;i++)
        {
            string detail=details[i];
            int age=(detail[11]-'0')*10;
            age+=(detail[12])-'0';
            if(age>60)
            output++;
        }
        return output;
    }
}