public class Solution {
    public bool IsPalindrome(string s) {
        int lp = 0;
        int up = s.Length -1;


        while(lp < up){
            while(lp < up && !char.IsLetterOrDigit(s[lp]))
                lp++;

            while(lp < up && !char.IsLetterOrDigit(s[up]))
                up--;

            if(char.ToLower(s[lp]) != char.ToLower(s[up]))
                return false;
            lp++;
            up--;
        }
        
        return true;
    }

}
