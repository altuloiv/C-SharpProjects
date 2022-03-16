using System;

namespace IncomeComparisonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring the type of information each value is prior to defining them.
            Decimal hourlyRate1, hourlyRate2, hoursWorked1, hoursWorked2, weeklyPerson1, weeklyPerson2, salaryPerson1, salaryPerson2;
            String hourlyRatePerson1, hourlyRatePerson2, hoursWorkedPerson1, hoursWorkedPerson2;
            bool moreThan;
            int weeksInYear = 52;

            //Beginning of program
            Console.WriteLine("Annonymous Income Comparison Program");
            Console.ReadLine();

            //Information for person 1, entering rate of pay, hours worked in the week.
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter the rate of pay.");
            hourlyRatePerson1 = Console.ReadLine();
            hourlyRate1 = Convert.ToDecimal(hourlyRatePerson1);
            Console.ReadLine();

            Console.WriteLine("Please enter the number of hours worked per week.");
            hoursWorkedPerson1 = Console.ReadLine();
            hoursWorked1 = Convert.ToDecimal(hoursWorkedPerson1);
            Console.ReadLine();

            //information for person 2, entering rate of pay, hours worked in the week
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter the rate of pay.");
            hourlyRatePerson2 = Console.ReadLine();
            hourlyRate2 = Convert.ToDecimal(hourlyRatePerson2);
            Console.ReadLine();
            
            Console.WriteLine("Please enter the number of hours worked per week.");
            hoursWorkedPerson2 = Console.ReadLine();
            hoursWorked2 = Convert.ToDecimal(hoursWorkedPerson2);

            //Calculating the Annual Salary for person 1 and 2
            Console.ReadLine();
            Console.WriteLine("Annual Salary Information for Person 1 is: ");
            weeklyPerson1 = hourlyRate1 * hoursWorked1;
            salaryPerson1 = weeklyPerson1 * weeksInYear;
            Console.WriteLine(salaryPerson1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary Information for Person 2 is: ");
            weeklyPerson2 = hourlyRate2 * hoursWorked2;
            salaryPerson2 = weeklyPerson2 * weeksInYear;
            Console.WriteLine(salaryPerson2);
            Console.ReadLine();

            //comparing salaries from person 1 and two to see who earn more money.
            moreThan = salaryPerson1 >= salaryPerson2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            Console.WriteLine(moreThan);
            Console.ReadLine();

        }
    }
}
