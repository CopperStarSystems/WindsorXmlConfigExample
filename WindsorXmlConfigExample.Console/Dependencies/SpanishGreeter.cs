//  --------------------------------------------------------------------------------------
// WindsorXmlConfigExample.Console.SpanishGreeter.cs
// 2017/06/20
//  --------------------------------------------------------------------------------------

using System;

namespace WindsorXmlConfigExample.Console.Dependencies
{
    public class SpanishGreeter : TimeOfDayGreeterBase
    {
        protected override string GetMorningGreeting()
        {
            return "Buenos días";
        }

        protected override string GetAfternoonGreeting()
        {
            return "Buenas tardes";
        }

        protected override string GetEveningGreeting()
        {
            return "Buenas noches";
        }
    }
}