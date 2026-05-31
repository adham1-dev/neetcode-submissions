public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int , int > d = new Dictionary<int , int >();


        for(int i =0;  i <nums.Length ; i++){
            int find = target - nums[i] ; 
            if(d.ContainsKey(find)){
                return new int[]{ d[find] , i};
            }
            d[nums[i]] = i;
        }
        return null;
    }
}
