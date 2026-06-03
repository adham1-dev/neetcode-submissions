class Solution {
    public int[] productExceptSelf(int[] nums) {
        int[] temp = new int[nums.length];
        int perfix = 1;
        for(int i = 0 ; i <nums.length ; i++){
            temp[i] = perfix;
            perfix *= nums[i];
        }
        int[] res = new int[nums.length];
        int suf =1;
        for(int i = nums.length-1 ; i >= 0 ; i--){
            res[i] = temp[i] * suf;
            suf *= nums[i];
        }
        return res;
    }
}  
