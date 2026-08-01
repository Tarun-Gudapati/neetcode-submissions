

class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        HashMap<Integer, Integer> freqMap = new HashMap<>();

        // Step 1: Build frequency map
        for (int num : nums) {
            freqMap.put(num, freqMap.getOrDefault(num, 0) + 1);
        }

        // Step 2: Create buckets
        List<Integer>[] buckets = new List[nums.length + 1]; // max freq = nums.length
        for (int key : freqMap.keySet()) {
            int freq = freqMap.get(key);
            if (buckets[freq] == null) {
                buckets[freq] = new ArrayList<>();
            }
            buckets[freq].add(key);
        }

        // Step 3: Gather top k frequent elements
        List<Integer> result = new ArrayList<>();
        for (int i = buckets.length - 1; i >= 0 && result.size() < k; i--) {
            if (buckets[i] != null) {
                result.addAll(buckets[i]);
            }
        }

        // Step 4: Only return first k elements
        int[] res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = result.get(i);
        }

        return res;
    }
}
