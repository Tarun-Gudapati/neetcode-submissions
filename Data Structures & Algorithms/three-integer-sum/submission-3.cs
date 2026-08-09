
public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> lst = new();

        Array.Sort(nums);
        int len = nums.Length;

        for (int i = 0; i < len; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = len - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum > 0)
                    right--;
                else if (sum < 0)
                    left++;
                else
                {
                    lst.Add(new List<int>
                    {
                        nums[i],
                        nums[left],
                        nums[right]
                    });

                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                        left++;

                    while (left < right && nums[right] == nums[right + 1])
                        right--;
                }
            }
        }

        return lst;
    }
}

