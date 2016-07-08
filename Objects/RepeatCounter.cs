using System.Collections.Generic;
using System;
// using System.Text.RegularExpressions;

namespace RepeatCounter.Objects
{
  public class RepeatCounter
  {

    public string inputWord;
    public string inputSentence;

    public static int CountRepeats(string inputWord, string inputSentence)
    {
      int repeatCount = 0;
      string lowerInputWord = inputWord.ToLower();
      string lowerInputSentence = inputSentence.ToLower();
      // lowerInputSentence = Regex.Replace(lowerInputSentence, @"[^a-z]", @" ");
      string[] sentenceArray = lowerInputSentence.Split(' ');
      for (var i = 0; i < sentenceArray.Length; i++)
      {
        if (sentenceArray[i].Contains(lowerInputWord))
        {
          repeatCount += 1;
        }
      }
      return repeatCount;
    }
  }
}
