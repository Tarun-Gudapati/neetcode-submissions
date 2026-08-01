class Solution {
    public int lengthOfLongestSubstring(String s) {
        //char[] ch=s.toCharArray();
        HashSet<Character> hs=new HashSet<>();
        int count=0;
        int position=0;
        for(int i=0;i<s.length();i++)
        {
            while(hs.contains(s.charAt(i)))
            {
                hs.remove(s.charAt(position));
                position++;
            }
            hs.add(s.charAt(i));
            count=Math.max(count,hs.size());
        }
        return count;

    }
}
