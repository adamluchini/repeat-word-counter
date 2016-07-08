using System.Collections.Generic;
using Xunit;

namespace RepeatCounter.Objects
{
  public class RepeatCounterTest
  {

    [Fact]
    public void CountRepeats_InputWordFindsExactMatchInInputSentenceOnce_1()
    {
    string inputSentence = "Tia and Tamera";
    string inputWord = "Tia";
    Assert.Equal(1, RepeatCounter.CountRepeats(inputSentence, inputWord));
    }

    [Fact]
    public void CountRepeats_InputWordDoesNotFindMatchInInputSentece_0()
    {
      string inputSentence = "Tia and Tamera";
      string inputWord = "Urkle";
      Assert.Equal(0, RepeatCounter.CountRepeats(inputSentence, inputWord));
    }

  }
}
