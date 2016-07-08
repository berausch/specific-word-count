using Nancy;
using RepeatCounters.Objects;
using System;
using System.Collections.Generic;

namespace WordCount
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
    Get["/"]=_=>{
      return View["index.cshtml"];
    };
    Get["/wordcount"]=_=>{
      RepeatCounter Counter = new RepeatCounter();
      int count = Counter.CountRepeats(
      Request.Query["phrase"],
      Request.Query["word"]
      );
      return View["wordcount.cshtml", count];
    };
    }
  }
}
