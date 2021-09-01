using System;

namespace DayOfTheWeekApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            var guesser = new DayGuesser();
            guesser.IntroduceTheApplication();
            guesser.AskUserForTheirDateOfBirth();
            guesser.CalculateDayOfTheWeek();
            guesser.PrintDayOfTheWeek();
        }
    }
}