using DayOfTheWeekApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheWeekApp
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateOfBirth { get; set; }

        public DayOfTheWeek UserDayOfTheWeek { get; set; }

        public void IntroduceTheApplication()
        {
            Console.WriteLine("Aplikacja, która potrafi wyliczyć dzień tygodnia na podstawie Twojej daty urodzienia.");

            Calculator = new DayCalculator();
        }

        public void AskUserForTheirDateOfBirth()
        {
            Console.WriteLine("Podaj swoją datę urodzenia: ");

            var userDate = Console.ReadLine();

            var succeded = DateTimeOffset.TryParse(userDate, out var date);

            if (succeded)
            {
                UserDateOfBirth = date;
                return;
            }

            Console.WriteLine("Format daty był niepoprawny! Proszę podać według wzoru dd/mm/yyyy");
            AskUserForTheirDateOfBirth();
        }

        public void CalculateDayOfTheWeek()
        {
            if (UserDateOfBirth == null)
            {
                Console.WriteLine("Próbowano obliczyć dzień tygodnia bez podania daty urodzenia.");
                return;
            }

            UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(UserDateOfBirth);
        }

        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Dzień tygodnia, w którym się urodziłeś/urodziłaś to: " + UserDayOfTheWeek.ToPolishString());
        }
    }
}