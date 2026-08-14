public class Solution {
    public int MaxArea(int[] heights) {
        int left=0;
        int right=heights.Length-1;
        int MaxArea=0;
        while(left<right)
        {

            if(heights[left]>=heights[right])
            {

                MaxArea=Math.Max((heights[right]*(right-left)),MaxArea);
                right--;
            }
            if(heights[left]<heights[right])
            {

                MaxArea=Math.Max((heights[left]*(right-left)),MaxArea);
                left++;
            }
        }
        return MaxArea;
    }
}
