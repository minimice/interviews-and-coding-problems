// I had to solve this in an hour with a badly formatted code sample that was given below
// Pretty much the only function I wrote was getWordsThatMatchAllLetters
// Everything else was copied and pasted from the ones who interviewd me
// Like lowerCasing function names, using a mix of var and string, this code could be much better!

/* 
Your previous Plain Text content is preserved below:
*/
/**
 * Instructions to candidate.
 *  1) Given a string of letters and a dictionary, the function longestWord should
 *     find the longest word or words in the dictionary that can be made from the letters
 *     Input: letters = "oet", dictionary = {"to","toe","toes"}
 *     Output: {"toe"}
 *     Only lowercase letters will occur in the dictionary and the letters
 *     The length of letters will be between 1 and 10 characters
 *     The solution should work well for a dictionary of over 100,000 words
 *  2) Run this code in the REPL to observe its behaviour. The
 *     execution entry point is main().
 *  3) Consider adding some additional tests in doTestsPass().
 *  4) Implement the longestWord() method correctly.
 *  5) If time permits, introduce '?' which can represent any letter.  "to?" could match to "toe", "ton" etc
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  class Dict {
    private string[] entries;
      
    public Dict(string[] entries) {
      this.entries = entries;
    }

    public bool contains(string word) {
      foreach (var entry in this.entries) {
        if (entry == word) {
          return true;
        }
      }
      return false;
    }
    
    // CGL: This is my code
    // There's a better solution probably but I didn't have time to look it up
    // and damn I get so tired at the end of the day!
    public HashSet<string> getWordsThatMatchAllLetters(string letters) {
        // letters -> "okbsetdg"
        // entries -> "book"
        var allResults = new List<string>();
        foreach (var entry in entries) {
            // "book"
            bool foundEveryLetter = true;
            string lettersCopy = letters;
            foreach (var character in entry) { // "book"
                int foundIndex = lettersCopy.IndexOf(character); 
                if (foundIndex != -1) { // okbsetdg.Contains("b")
                    lettersCopy = lettersCopy.Remove(foundIndex,1);
                } else {
                    foundEveryLetter = false;
                    break;
                }
            }
            if (foundEveryLetter) {
                allResults.Add(entry);
            }
        }
        
        // Sort by longestWord
        string longestWord = allResults.OrderByDescending(x => x.Length).First();
        
        // Return all words that have the longest length
        return new HashSet<string>(allResults.Where(word => word.Length == longestWord.Length));
    }
  }
  // End of my code
  
  class LongestWordSolution
  {
    public static HashSet<string> longestWord(string letters, Dict dict) {
      // letters -> "osetdg"
      // dict -> "to", "toe", "toes", "doe", "dog", "god", "dogs", "book", "banana"
      return dict.getWordsThatMatchAllLetters(letters);
    }
    
    public static bool doesTestPass(Dict dict, string letters, List<string> expectedResult) {
      // dict -> "to", "toe", "toes", "doe", "dog", "god", "dogs", "book", "banana"
      // letters -> "osetdg"
      // expectedResult -> "toes","dogs"
      var expectedResultSet = new HashSet<string>(expectedResult); // "osetdg"
      var resultSet = longestWord(letters, dict);
      return resultSet.SetEquals(expectedResultSet);
    }
    
    public bool doTestsPass() {
      Dict dict = new Dict(new string[]{"to", "toe", "toes", "doe", "dog", "god", "dogs", "book", "banana"});
      
      bool result = doesTestPass(dict, "toe", new List<string>{"toe"});
      result = result && doesTestPass(dict, "osetdg", new List<string>{"toes","dogs"})
                      && doesTestPass(dict, "ookbsetdg", new List<string>{"toes","dogs","book"})
                      && !doesTestPass(dict, "okbsetdg", new List<string>{"toes","dogs","book"});

      return result;
    }
    
    // Execution entry point
    static void Main(string[] args) {    
      if (new LongestWordSolution().doTestsPass()) {
        Console.WriteLine("All tests pass");
      } else {
        Console.Error.WriteLine("There are test failures");
      }
    }
  }
}
