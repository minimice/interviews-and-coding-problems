using System;
using System.Text;

// GS asked me to solve this problem in Coderpad
// Live programming

/**
 * Instructions to candidate.
 *  1) Run this code in the REPL to observe its behaviour.
 *  2) Consider adding some additional tests in doTestsPass().
 *  3) Implement rle() correctly.
 *  4) If time permits, try to improve your implementation.
 *

**
**   Implement a run length encoding function.
 *
 * For a string input the function returns output encoded as follows:
 *
 * "a"     -> "a1"
 * "aa"    -> "a2"
 * "aabbb" -> "a2b3"
 *
 */

public class Solution
{
    // Edge cases
    // null: string.Empty
    // " ": " 1"
    public static string rle(string input)
    {
        // Check for edge cases
        if (String.IsNullOrEmpty(input))
        {
            return String.Empty;
        }
        
        var resultSB = new StringBuilder();
        var letterCount = 0;
        var letterToCompareAgainst = input[0];
        
        // Loop through input
        foreach (var letter in input)
        {
            if (letter.Equals(letterToCompareAgainst))
            {
                letterCount++;
            }
            else
            {
                // Letters have changed
                resultSB.Append(letterToCompareAgainst);
                resultSB.Append(letterCount);
                // Reset the count 
                letterCount = 1;
                letterToCompareAgainst = letter;
            }
        }
        
        // Last letter needs a count
        resultSB.Append(letterToCompareAgainst);
        resultSB.Append(letterCount);
        
        return resultSB.ToString();
    }
    
    public static bool rle_GivenStringABA_ExpectA1B1A1()
    {
        return rle("ABA") == "A1B1A1";
    }
    
    public static bool rle_GivenStringAAABBB_ExpectA3B3()
    {
        return rle("AAABBB") == "A3B3";
    }
    
    public static bool rle_GivenStringAAABBBC_ExpectA3B3C1()
    {
        return rle("AAABBBC") == "A3B3C1";
    }

    public static bool rle_GivenStringNull_ExpectEmptyString()
    {
        return rle(null) == string.Empty;
    }

    public static void doTestsPass()
    {
        bool passes = rle( "" ) == "" &&
                      rle( "a" ) == "a1" &&
                      rle("aaa") == "a3" &&
                      rle_GivenStringAAABBB_ExpectA3B3() &&
                      rle_GivenStringNull_ExpectEmptyString() &&
                      rle_GivenStringAAABBBC_ExpectA3B3C1() &&
                      rle_GivenStringABA_ExpectA1B1A1();

        if (passes)
            Console.WriteLine("RLE Tests pass");
        else
            Console.WriteLine("RLE Tests Failed");
    }

    static void Main(String[] args)
    {
        doTestsPass();
    }
}

