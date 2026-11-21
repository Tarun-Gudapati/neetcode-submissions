class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        start=0
        stop=len(numbers)-1
        while(start<stop):
            sum_val=numbers[start]+numbers[stop]
           
            if(sum_val==target):
                return [start+1,stop+1]
            elif(sum_val>target):
                stop-=1
            elif(sum_val<target):
                start+=1
        return[-1,-1]

            