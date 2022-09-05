using System;

namespace ConsoleApp11
{
    internal static class ProgramHelpers
    {
        static void DateTimeOperation()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine($"it's{now.Date}, {now.Minute} ");

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newDt = dt.AddDays(1);
            Console.WriteLine(newDt);

            TimeSpan t = now - dt;
            t = now.Subtract(dt);
            Console.WriteLine(t.Days);
        }
    }
}