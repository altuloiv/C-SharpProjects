using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of string variable format
            string[] welcome = new string[] { "Welcome, ", "Thank you for joining us today, ", "Hope to see you again, " };
            Console.WriteLine("Enter your first name, then press enter.");
            string userInput = Console.ReadLine();
            for (int i = 0; i < welcome.Length; i++)
            {
                Console.WriteLine(welcome[i] += userInput);
            }
            Console.ReadLine();

            // infinaite loop
            // for (int g = 0; g < 50; g--)
            //{
            //      Console.WriteLine("Value : {0}", g);
            //}
            //Console.ReadLine();

            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Value of c: {0}", c);
            }
            Console.ReadLine();

            for (int b = 0; b <= 5; b++)
            {
                Console.WriteLine("b value: {0}", b);
            }
            Console.ReadLine();

            //string of unique values
            List<string> cityList = new List<string>() { "Chicago", "Pheonix", "New York" };
            Console.WriteLine("Enter the name of your city");
            string UserInputs = Console.ReadLine();
            bool inputCheck = false;
            int inputIndex;
            foreach (string city in cityList)
            {
                if (UserInputs == city)
                {
                    inputCheck = true;
                    inputIndex = cityList.IndexOf(city);
                    Console.WriteLine(inputIndex);
                }
            }

            if (inputCheck == false)
            {
                Console.WriteLine("Index not found.");
            }
            Console.ReadLine();


            // String of unique values with identicals
            List<string> doggyList = new List<string>() { "German Shephard", "Corgi", "Pitbull", "Corgi", "Schnauzer,", "Bulldog" };
            Console.WriteLine("Enter a breed of dog.");
            string doggyInput = Console.ReadLine();
            for (int index = 0; index < doggyList.Count; index++)
                if (doggyList[index] == doggyInput)
                {
                    Console.WriteLine(index);
                }
            if (!doggyList.Contains(doggyInput))
            {
                Console.WriteLine("No such doggy found");
            }
            Console.ReadLine();

            List<string> sameList = new List<string>() { "Ace", "Jack", "Queen", "King", "Ten", "Ace", "Ten" };
            List<string> mList = new List<string>();
            foreach (string same in sameList)
            {
                if (mList.Contains(same))
                {
                    Console.WriteLine("The card " + same + " has occurred before.");
                }
                else
                {
                    Console.WriteLine("The card " + same + " has not appeared before.");
                }

                mList.Add(same);
            }
            Console.ReadLine();
        }
    }
}
