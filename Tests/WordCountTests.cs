using Xunit;

namespace RepeatCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void ContainsWord_SentenceContainsWord_false()
    {
      RepeatCounter Containstest = new RepeatCounter();
      Assert.Equal(true, Containstest.ContainsWord("you like cheese", "pizza"));
    }
    [Fact]
    public void ContainsWord_SentenceContainsWord_true()
    {
      RepeatCounter Containstest = new RepeatCounter();
      Assert.Equal(true, Containstest.ContainsWord("you like cheese", "cheese"));
    }
    [Fact]
    public void CountRepeats_CountsWordRepeatsinSentence_false()
    {
      RepeatCounter Containstest = new RepeatCounter();
      Assert.Equal(1, Containstest.CountRepeats("you like cheese", "cheese"));
    }
  }
}
