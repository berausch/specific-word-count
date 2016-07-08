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
  }
}
