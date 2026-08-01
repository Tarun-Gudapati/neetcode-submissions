class Solution {
    public boolean isValid(String s) {
        if(s.length()==0||s.length()%2!=0)
        return false;
        Stack <Character> stack=new Stack<>();
        char[] ch=s.toCharArray();
        for(int i=0;i<s.length();i++)
        {
            if(ch[i]=='('||ch[i]=='{'||ch[i]=='[')
            {
                stack.push(ch[i]);
            }
            else
            {
                if (stack.isEmpty()) return false;
                char op=stack.pop();
                if((ch[i]==')' && op!='(')||(ch[i]==']' && op!='[')||(ch[i]=='}' && op!='{') )
                return false;
            }
            
        }
        return stack.isEmpty();

        
    }
}
