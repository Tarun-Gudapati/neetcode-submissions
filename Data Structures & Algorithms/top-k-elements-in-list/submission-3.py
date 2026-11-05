class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        freq={}
        for num in nums:
            freq[num]=freq.setdefault(num,0)+1
        freq=sorted(freq.items(),key=lambda item:item[1],reverse=True)
        result=[]
        for i in range(k):
            result.append(freq[i][0])
        return result


        
        