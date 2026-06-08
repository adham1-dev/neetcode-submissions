public class Solution {
    public bool IsPalindrome(string s) {
        int lp = 0;
        int up = s.Length -1;


        while(lp < up){
            if(!char.IsLetterOrDigit(s[lp])){
                lp++;
                continue;
            }

            if(!char.IsLetterOrDigit(s[up])){
                up--;
                continue;
            }

            if(char.ToLower(s[lp]) != char.ToLower(s[up]))
                return false;
            lp++;
            up--;
        }
        
        return true;
    }

}
