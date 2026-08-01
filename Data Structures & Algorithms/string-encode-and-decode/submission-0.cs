public class Solution {

        public string Encode(IList<string> strs)
 {
     StringBuilder stringBuilder = new StringBuilder(); ;
     foreach (var val in strs)
     {
        stringBuilder.Append(val.Length).Append("#").Append(val);
     }
     return stringBuilder.ToString();
   
 }

 public List<string> Decode(string s)
 {
     List<string> result = new List<string>();
     int i = 0;
     while (i<s.Length)
     {
         int j = i;
         while (s[j]!='#')j++;
         int LengthOfWord =int.Parse( s.Substring(i, j - i));
         string word=s.Substring(j+1,LengthOfWord);
         result.Add(word);
         i = j+1+LengthOfWord;

     }
     return result;

 }
}
