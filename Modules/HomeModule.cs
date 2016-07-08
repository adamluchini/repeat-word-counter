using System.Collections.Generic;
using System;
using Nancy;


namespace RepeatCounter.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

    Get["/"]= _ => {
      return View["index.cshtml"];
      };

    Post["/result"]= _ => {
      return View["result.cshtml", RepeatCounter.CountRepeats(Request.Form["inputWord"], Request.Form["inputSentence"])];
      };
    }
  }
}
