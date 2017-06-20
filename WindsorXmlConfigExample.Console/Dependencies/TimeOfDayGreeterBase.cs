//  --------------------------------------------------------------------------------------
// WindsorXmlConfigExample.Console.TimeOfDayGreeterBase.cs
// 2017/06/20
//  --------------------------------------------------------------------------------------

using System;

namespace WindsorXmlConfigExample.Console.Dependencies
{
    public abstract class TimeOfDayGreeterBase : IGreeter
    {

        protected abstract string GetMorningGreeting();

        protected abstract string GetAfternoonGreeting();

        protected abstract string GetEveningGreeting();

        public string Greet(string name)
        {
            return $"{GetGreetingPrefix()}, {name}";
        }

        string GetGreetingPrefix()
        {
            var timeOfDay = DateTime.Now.Hour;
            if (timeOfDay > 18)
                return GetEveningGreeting();
            if (timeOfDay > 13)
                return GetAfternoonGreeting();
            return GetMorningGreeting();
        }
    }
}