class Solution{
  public List<List<String>> groupAnagrams(String[] strs) {
        //List <String> AnagramlList=new ArrayList<>();
        List<List<String>> result=new ArrayList<>();
        HashMap<String,List<String>>hs=new HashMap<>();
        for(String str:strs)
        {
            char[]ch=str.toCharArray();
            Arrays.sort(ch);
            String sortedString=new String(ch);
            if(!hs.containsKey(sortedString))
            {
              hs.put(sortedString,new ArrayList<>());
            }
            hs.get(sortedString).add(str);
        }


        result=new ArrayList<>(hs.values());
        return result;
  }
}
