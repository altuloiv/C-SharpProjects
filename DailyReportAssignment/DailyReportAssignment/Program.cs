using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");


            // here begins the daily report questionaire
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("Welcome " + studentName);
            Console.ReadLine();


            // asks which program they are enrolled in
            Console.WriteLine("What course are you enrolled in?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are enrolled in " + courseName);
            Console.ReadLine();

            // Asks what page they are on
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("You're working on page number " + pageNumber);
            Console.ReadLine();

            //asks if there is anything they need help with
            Console.WriteLine("Do you help with anything?\nPlease answer \"true\" or \"false\".");
            Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("If you need help, please contact the instructors via email or telephone.");
            Console.ReadLine();

            //asks about their expereince so far
            Console.WriteLine("Are there any psoitive expereinces you would like to share? Please give anything specific.");
            string studentExpereince = Console.ReadLine();
            Console.WriteLine("thank you " + studentName + "!");
            Console.WriteLine("You wrote " + studentExpereince);
            Console.ReadLine();

            //asks for feedback
            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();
            Console.WriteLine("Thank you " + studentName + "!");
            Console.WriteLine("You wrote " + studentFeedback);


            //asks how many  hours they studied for the day
            Console.WriteLine("How many hours did you study today?");
            Convert.ToString(Console.ReadLine());
            Console.WriteLine("Great job with our studies!");
            Console.ReadLine();

            //thank the student for the answers
            Console.WriteLine("Thank you for your answers.\nAn instructor will review your responses shortly.\nHave a great day!");
            Console.ReadLine();

            //end the program
            Console.Clear();
        }
    }
}
