using System.Collections.Generic;
using Xunit;
// using System.Text.RegularExpressions;

namespace RepeatCounter.Objects
{
  public class RepeatCounterTest
  {

    [Fact]
    public void CountRepeats_InputWordFindsExactMatchInInputSentenceOnce_1()
    {
    string inputWord = "Tia";
    string inputSentence = "Tia and Tamera";
    Assert.Equal(1, RepeatCounter.CountRepeats(inputWord, inputSentence));
    }

    [Fact]
    public void CountRepeats_InputWordDoesNotFindMatchInInputSentece_0()
    {
      string inputWord = "Urkle";
      string inputSentence = "Tia and Tamera";
      Assert.Equal(0, RepeatCounter.CountRepeats(inputWord, inputSentence));
    }

    [Fact]
    public void CountRepeats_InputWordFindsExactMatchInInputSentenceMultipleTimes_2()
    {
      string inputWord = "Sister";
      string inputSentence = "Sister Sister starring Tia and Tamera";
      Assert.Equal(2, RepeatCounter.CountRepeats(inputWord, inputSentence));
    }

    [Fact]
    public void CountRepeats_InputWordFindsMatchInInputSentenceRegardlessOfCase_2()
    {
      string inputWord = "sister";
      string inputSentence = "Sister Sister starring Tia and Tamera";
      Assert.Equal(2, RepeatCounter.CountRepeats(inputWord, inputSentence));
    }

    [Fact]
    public void CountRepeats_InputWordFindsMatchInInputSentecesRegardlessOfPunctuation_2()
    {
      string inputWord = "sister";
      string inputSentence = "'SISTER, SISTER!!!!' starring Tia and Tamera";
      Assert.Equal(2, RepeatCounter.CountRepeats(inputWord, inputSentence));
    }

    // [Fact]
    // public void CountRepeats_InputWordDoesNotFindMatchInInputSentenceIfPartialMatch_0()
    // {
    //   string inputSentence = "Sister, Sister starring Tia and Tamera";
    //   string inputWord = "star";
    //   Assert.Equal(0, RepeatCounter.CountRepeats(inputSentence, inputWord));
    // }

  }
}
