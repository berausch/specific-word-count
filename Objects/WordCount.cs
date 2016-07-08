using Nancy;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RepeatCounter.Objects
{
  public class RepeatCounter
  {
    public bool ContainsWord(string inputPhrase, string inputWord)
    {

      return inputPhrase.Contains(inputWord);
    }
    public int CountRepeats(string inputPhrase, string inputWord)
    {
      RepeatCounter newCounter = new RepeatCounter();
      if(newCounter.ContainsWord(inputPhrase, inputWord)== true)
      {
      return 1;
      } else {
        return 0;
      }
    }
  }
}
