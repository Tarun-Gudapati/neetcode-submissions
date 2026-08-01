class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int m=0;
        int len=numbers.length-1;
        while(m<len)
        {
            if((numbers[m]+numbers[len])==target)
            return new int[] {m+1,len+1};
            else
            {
                if((numbers[m]+numbers[len])>target)
                len--;
                else
                {
                    m++;
                }
            }
        }
        return null;
    }
}
