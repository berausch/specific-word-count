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
      int counter = 0;
      if(newCounter.ContainsWord(inputPhrase, inputWord)== true)
      { string[] phraseArray = inputPhrase.ToLower().Split(' ');
       foreach(string word in phraseArray)
       { if(word.EndsWith("?") == true|| word.EndsWith(".") == true ||word.EndsWith("!") == true || word.EndsWith(",") == true){

         string word2 = word.Remove(word.Length -1);
         if(word2 == inputWord){
           counter+=1;
         }
       }
         if(word == inputWord){
           counter+=1;
         }
       }
       return counter;
      } else {
        return 0;
      }
    }
    public bool WordNotSingular(string inputWord){
      return inputWord.Contains(" ");
    }
  }
}
