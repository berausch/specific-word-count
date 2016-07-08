using Xunit;

namespace RepeatCounter.Objects
{
  public class RepeatCounterTest
  {
    // [Fact]
    // public void ContainsWord_SentenceContainsWord_false()
    // {
    //   RepeatCounter Containstest = new RepeatCounter();
    //   Assert.Equal(true, Containstest.ContainsWord("you like cheese", "pizza"));
    // }
    [Fact]
    public void ContainsWord_SentenceContainsWord_true()
    {
      RepeatCounter Containstest = new RepeatCounter();
      Assert.Equal(true, Containstest.ContainsWord("you like cheese", "cheese"));
    }
    [Fact]
    public void CountRepeats_CountsWordRepeatsinSentence_true()
    {
      RepeatCounter Containstest = new RepeatCounter();
      Assert.Equal(2, Containstest.CountRepeats("to be or not to be", "to"));
    }
    [Fact]
    public void CountRepeats_CountsWordRepeatsinSentenceCaseMismatch_true()
    {
      RepeatCounter Containstest = new RepeatCounter();
      Assert.Equal(2, Containstest.CountRepeats("To be or not to be", "to"));
    }
    [Fact]
    public void CountRepeats_CountsWordRepeatsinSentenceSpecialChars_true()
    {
      RepeatCounter Containstest = new RepeatCounter();
      Assert.Equal(2, Containstest.CountRepeats("To be or not to be?", "be"));
    }
  }
}
