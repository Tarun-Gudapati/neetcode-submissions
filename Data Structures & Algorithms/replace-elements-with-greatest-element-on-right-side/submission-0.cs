public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int x=arr.Length;
        int last=arr[x-1];
        arr[x-1]=-1;
        for(int i=x-2;i>=0;i--)
        {
            if(arr[i]>last)
            {
            int lbf=last;
            last=arr[i];
            arr[i]=lbf;
            }
            else
            arr[i]=last;
        }
        return arr;
    }
}