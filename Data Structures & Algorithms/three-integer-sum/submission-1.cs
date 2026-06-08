public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        if(nums.Length == 0 || nums[0] > 0)
            return new List<List<int>>();

        var res = new List<List<int>>() ;

        for(int i=0 ; i < nums.Length; i++){
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int lp = i+1;
            int up = nums.Length-1;
            while(lp < up){
                int temp = nums[lp] + nums[up] + nums[i];
                if( temp == 0){
                    res.Add(new int[]{nums[lp] , nums[up] , nums[i]}.ToList());
                    lp++;
                    while (lp < up && nums[lp] == nums[lp - 1]) lp++;
                }
                else if( temp > 0)
                    up--;
                else
                    lp++;
            }
        }

        return res;

    }
}
