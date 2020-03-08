/*frequency of occurrence of a digit problem

First line is k
Next line is n

input
2
22

Count number of ks from 0 to n inclusive
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22

ans 14 (2, 12, 20, 21, 22, ... in this example there are 6 2s)
*/

//Hit compile and run to see a sample output.
//Read values from stdin, do NOT hard code input.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        // Read values of k and n
        var k = Int32.Parse(Console.ReadLine());
        var n = Int32.Parse(Console.ReadLine());

        var numberOfKs = 0;

        // Loop between 0 and n
        for (int i = 0; i <= n; i++)
        {
            // Count number of ks in i
            numberOfKs += CountKs(k, i);
        }

        Console.WriteLine(numberOfKs);
    }

    static int CountKs(int k, int number)
    {
        var kCount = 0;

        // Convert k to char
        var kChar = k.ToString()[0];

        // Convert number to array and check if each character
        // is equal to kChar
        foreach (var c in number.ToString().ToCharArray())
        {
            if (c == kChar)
            {
                kCount++;
            }
        }

        return kCount;
    }
}
