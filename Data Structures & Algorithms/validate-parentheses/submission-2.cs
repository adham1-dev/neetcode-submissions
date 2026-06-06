public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        foreach(char c in s){
            switch(c){
                case '(':
                case '[':
                case '{':
                    st.Push(c);
                break;
                case ')':
                case ']':
                case '}':
                    if(st.Count > 0 && st.Peek() == open(c))
                        st.Pop();
                    else
                        return false;
                break;
            }

        }

        return (st.Count == 0);

    }

    char open(char close){
        switch(close){
            case ')':
            return '(';
            case ']':
            return '[';
            case '}':
            return '{';
            default : return 'x';
        }   
    }
}
