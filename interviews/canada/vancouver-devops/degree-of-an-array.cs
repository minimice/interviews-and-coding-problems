/*Degree of an array


Given a non-empty array N, of non-negative integers , the degree of this array is defined as the maximum frequency of any one of its elements. Your task is to find the smallest possible length of a (contiguous) subarray of N, that has the same degree as N. For example, in the array [1 2 2 3 1], integer 2 occurs maximum of twice. Hence the degree is 2.

Input

Test case input contains 2 lines.
First line contains an integer T, representing the number of elements in the array.
The second line contains the array N, list of T integers each separated by space.

Output

Print the length of the smallest contiguous subarray of input array N, that has the same degree as N.
Code evaluation is based on your output, please follow the sample format and do NOT print anything else.



e.g
5
1 2 2 3 1

output
2
*/




//Hit compile and run to see a sample output.
//Read values from stdin, do NOT hard code input.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        string line = Console.ReadLine();
        var size = Int32.Parse(line);
        var input = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
        int currentMaxFrequency = 0;
        int currentNumber = input[0];
        int currentNumberFrequency = 0;
        foreach (var number in input)
        {
            if (currentNumber == number)
            {
                currentNumberFrequency++;
            }
            else
            {
                if (currentNumberFrequency > currentMaxFrequency)
                {
                    currentMaxFrequency = currentNumberFrequency;
                }
                currentNumberFrequency = 1;
                currentNumber = number;
            }
        }
        Console.Write(currentMaxFrequency);
    }
}
