class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map <string , vector<string>> map;
        
        for(const string& s : strs){
            int freq[26] = {0};
            for(char c : s){
                freq[c - 'a']++;
            }
            string key = to_string(freq[0]);
            for(int i : freq){
                key += ',' + to_string(i); 
            }
            map[key].push_back(s);
        }
        vector<vector<string>> res;
        for(const auto& pair : map){
            res.push_back(pair.second);
        }
        return res;

    }
};
