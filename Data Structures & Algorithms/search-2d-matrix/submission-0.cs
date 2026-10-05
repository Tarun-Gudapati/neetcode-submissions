public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows=matrix.Length;
        int cols=matrix[0].Length;
        for(int row=0;row<rows;row++)
        {
            int start=matrix[row][0];
            int end=matrix[row][cols-1];
            if(target>=start && target<=end)
            {
                int left=0;
                int right=cols-1;
                while(left<=right)
                {
                    int mid=left+(right-left)/2;
                    int val=matrix[row][mid];
                    if(target<val)
                    right=mid-1;
                    else if(target>val)
                    left=mid+1;
                    else if(target==val)
                    return true;
                }

            }
            
        }
        return false;

    }
}
