public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length-1;
        int max = 0;
        
        while(l<r){
            
            int res = (r - l) * (Math.Min(heights[l] , heights[r]));
            if(res > max)
                max =res;
            
            if(heights[l] < heights[r])
                l++;
            else
                r--;
        }

        
        return   max ; 

    }
}
