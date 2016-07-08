using System.Collections.Generic;
using System;

namespace RepeatCounter.Objects
{
  public class RepeatCounter
  {

    public string inputSentence;
    public string inputWord;

    public static int CountRepeats(string inputSentence, string inputWord)
    {
      int repeatCount = 0;
      string[] sentenceArray = inputSentence.Split(' ');
      for (var i = 0; i < sentenceArray.Length; i++)
      {
        if (sentenceArray[i].ToLower().Contains(inputWord.ToLower()))
        {
          repeatCount += 1;
        }
      }
      return repeatCount;
    }
  }
}
