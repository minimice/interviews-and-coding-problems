import java.util.*;
import java.util.regex.*;

// Write your code here. DO NOT use an access modifier in your class declaration.
class Parser {
    public String isBalanced(String input) {
        if (input.isEmpty()) { // Empty
            return "true";
        }
        if (input.length() % 2 != 0) { // Odd length
            return "false";
        }
        Stack<Character> stack = new Stack<Character>();
        for (int i = 0; i < input.length(); i++) {
            char s = input.charAt(i);
            if (s == '{' || s == '(')
            {
                stack.push(s);
            }
            if (s == '}' || s == ')')
            {
                if (stack.size() == 0)
                {
                    return "false";
                }
                char matching = stack.pop();
                if (s == '}' && matching == '{' || s == ')' && matching == '(')
                {
                    continue;
                }
                else
                {
                    return "false";
                }
            }
        }

        if (stack.size() > 0)
        {
            return "false";
        }

        return "true";
    }
}