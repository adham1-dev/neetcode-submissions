class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
                unordered_map<int, int> ranks;
        for(int i : nums)
            ranks[i]++;
        
        vector<vector<int>> buckets (nums.size() + 1);
        for(const auto& rank : ranks){
            buckets[rank.second].push_back(rank.first);
        }
        vector<int> res;
        for(int i = buckets.size()-1 ; i>0 ; i--){
            for(int n : buckets[i]){
                res.push_back(n);
                if(res.size() == k){
                    return res;
                }
            }

        }
        return res;
    }
};
