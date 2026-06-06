public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int max  = 0 ;
        int temp =0;
        foreach(int n in nums){
            if(!set.Contains(n-1)){
                for(int i = n ; set.Contains(i) ; i++){
                    temp++;
                }
                if(temp > max)
                    max = temp;
                temp =0 ;
            }
        }
        return max;
    }
}
