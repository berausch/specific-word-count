using Nancy;
using RepeatCounter.Objects;
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
    }
    }
  }
}
