class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        singularity=set()
        for num in nums:
            if num in singularity :return True
            singularity.add(num)
        return False
        