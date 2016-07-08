using Xunit;

namespace RepeatCounters.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void ContainsWord_SentenceContainsWord_true()
    {
      RepeatCounter Containstest = new RepeatCounter();
      Assert.Equal(true, Containstest.ContainsWord("you like cheese", "cheese"));
    }
    [Fact]
    public void CountRepeats_CountsWordRepeatsinSentence_true()
    {
      RepeatCounter CountTest = new RepeatCounter();
      Assert.Equal(2, CountTest.CountRepeats("to be or not to be", "to"));
    }
    [Fact]
    public void CountRepeats_CountsWordRepeatsinSentenceCaseMismatch_true()
    {
      RepeatCounter CountTest = new RepeatCounter();
      Assert.Equal(2, CountTest.CountRepeats("To be or not to be", "to"));
    }
    [Fact]
    public void CountRepeats_CountsWordRepeatsinSentenceSpecialChars_true()
    {
      RepeatCounter CountTest = new RepeatCounter();
      Assert.Equal(2, CountTest.CountRepeats("to be or not to be?", "be"));
    }
    [Fact]
    public void WordNotSingular_InputWordMultipleWords_true()
    {
      RepeatCounter SingularTest = new RepeatCounter();
      Assert.Equal(true, SingularTest.WordNotSingular("to be"));
    }
  }
}
