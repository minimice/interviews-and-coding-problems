using System;
using System.Collections.Generic;


// CHOOI GUAN LIM solution
public class Solution {

    static public string Run(bool morseToEnglish, string textToTranslate) {
    	
    	Dictionary<string,string> lettersToMorse = new Dictionary<string,string>();
		lettersToMorse.Add("a",".-");
		lettersToMorse.Add("b","-...");
		lettersToMorse.Add("c","-.-.");
		lettersToMorse.Add("d","-..");
		lettersToMorse.Add("e",".");
		lettersToMorse.Add("f","..-.");
		lettersToMorse.Add("g","--.");
		lettersToMorse.Add("h","....");
		lettersToMorse.Add("i","..");
		lettersToMorse.Add("j",".---");
		lettersToMorse.Add("k","-.-");
		lettersToMorse.Add("l",".-..");
		lettersToMorse.Add("m","--");
		lettersToMorse.Add("n","-.");
		lettersToMorse.Add("o","---");
		lettersToMorse.Add("p",".--.");
		lettersToMorse.Add("q","--.-");
		lettersToMorse.Add("r",".-.");
		lettersToMorse.Add("s","...");
		lettersToMorse.Add("t","-");
		lettersToMorse.Add("u","..-");
		lettersToMorse.Add("v","...-");
		lettersToMorse.Add("w",".--");
		lettersToMorse.Add("x","-..-");
		lettersToMorse.Add("y","-.--");
		lettersToMorse.Add("z","--..");
		lettersToMorse.Add("1",".----");
		lettersToMorse.Add("2","..---");
		lettersToMorse.Add("3","...--");
		lettersToMorse.Add("4","....-");
		lettersToMorse.Add("5",".....");
		lettersToMorse.Add("6","-....");
		lettersToMorse.Add("7","--...");
		lettersToMorse.Add("8","---..");
		lettersToMorse.Add("9","----.");
		lettersToMorse.Add("0","-----");
		lettersToMorse.Add(".",".-.-.-");
		lettersToMorse.Add(",","--..--");
		lettersToMorse.Add("?","..--..");
		lettersToMorse.Add("'",".----.");
		lettersToMorse.Add("!","-.-.--");

		Dictionary<string,string> morseToLetters = new Dictionary<string,string>();
		foreach (var kvp in lettersToMorse)
		{
			morseToLetters.Add(kvp.Value, kvp.Key);
		}
    	
    	string translatedText = "";
        if (morseToEnglish)
        {
        	translatedText = ConvertMorseToEnglish(textToTranslate, morseToLetters);
        }
        else
        {
        	translatedText = ConvertEnglishToMorse(textToTranslate, lettersToMorse);
        }
		
		return translatedText;
	}
	
	static public string ConvertEnglishToMorse(string textToTranslate, Dictionary<string,string> lettersToMorse)
	{
		string translated = "";
		foreach (char c in textToTranslate)
		{
			if (c == ' ')
			{
				translated += "  ";
				continue;
			}
			string morse = "";
			//System.out.printline(c.ToString);
			if (lettersToMorse.TryGetValue(c.ToString().ToLower(), out morse))
			{
				translated += morse + " ";
			}
			else
			{
				return "Invalid Morse Code Or Spacing";
			}
		}
		
		// Replace "    " with "      "
		// i.e. two spaces in english to 6 spaces in morse
		translated = translated.Replace("    ","      ");
		
		return translated;
	}
	
	static public string ConvertMorseToEnglish(string textToTranslate, Dictionary<string,string> morseToLetters)
	{
		if (textToTranslate.IndexOf("    ") != -1
			||
			textToTranslate.Length == 0)
		{
			return "Invalid Morse Code Or Spacing";
		}
		string translated = "";
		// split on words first
		var morseCodeWords = textToTranslate.Split(new string[] {"   "}, StringSplitOptions.None);
		foreach (var morseWord in morseCodeWords)
		{
			var morseCode = morseWord.Split(new string[] {" "}, StringSplitOptions.None);
			foreach (var morse in morseCode)
			{
				string letter;
				if (morseToLetters.TryGetValue(morse, out letter))
				{
					translated += letter;
				}
			}
			translated += " ";
		}
		
		return translated;
	}
}