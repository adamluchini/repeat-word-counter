using System.Collections.Generic;
using Xunit;

namespace RepeatCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_InputWordFoundInInputSentenceIfExactMatch_1()
    {
    string inputSentence = "Tia and Tamera";
    string inputWord = "Tia";
    Assert.Equal(1, RepeatCounter.CountRepeats(inputSentence, inputWord));
    }

  }
}
