class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        checkers={}
        for index,value in enumerate(nums):
            if target-value in checkers:
                return sorted([index,checkers[target-value]])
            checkers[value]=index
        return [-1,-1]
        