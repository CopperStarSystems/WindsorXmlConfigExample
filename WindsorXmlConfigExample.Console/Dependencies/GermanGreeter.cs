//  --------------------------------------------------------------------------------------
// WindsorXmlConfigExample.Console.GermanGreeter.cs
// 2017/06/20
//  --------------------------------------------------------------------------------------

namespace WindsorXmlConfigExample.Console.Dependencies
{
    public class GermanGreeter : TimeOfDayGreeterBase
    {
        protected override string GetAfternoonGreeting()
        {
            return "Guten Nachmittag";
        }

        protected override string GetEveningGreeting()
        {
            return "Guten Abend";
        }

        protected override string GetMorningGreeting()
        {
            return "Guten Morgen";
        }
    }
}