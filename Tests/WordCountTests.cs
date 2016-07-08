using Xunit;

namespace RepeatCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void ContainsWord_SentenceContainsWord_false()
    {
      RepeatCounter Containstest = new RepeatCounter();
      Assert.Equal(false, Containstest.ContainsWord("to be", "not")); 
    }
  }
}
