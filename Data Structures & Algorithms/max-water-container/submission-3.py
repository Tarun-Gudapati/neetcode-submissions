class Solution:
    def maxArea(self, nums: List[int]) -> int:
        maxarea=0
        n=len(nums)
        left=0
        right=n-1
        while(left<right):
            area=min(nums[left],nums[right])*(right-left)
            maxarea=max(area,maxarea)
            if nums[left]<nums[right]:
                left+=1
            else:
                right-=1
        return maxarea
