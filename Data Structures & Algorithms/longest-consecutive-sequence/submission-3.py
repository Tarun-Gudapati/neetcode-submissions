class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        allvalues=set()
        
        for i in range(len(nums)):
            allvalues.add(nums[i])
        longestConsec=1
        for i in allvalues:
            if i-1 not in allvalues:
                count=1
                while(i+count in allvalues):
                    count+=1
                longestConsec=max(longestConsec,count)
        return min(longestConsec,len(nums))

        