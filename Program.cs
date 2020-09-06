using System;

namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.WriteLine(" from method Main");
            Console.ReadLine();

            // Begin
            string name = Accept_String_Info("What's your name? ");
            int age = int.Parse(Accept_String_Info("How old are you? "));
            DateTime mydate = DateTime.Now;

            Console.WriteLine("Current Date {0}",mydate.ToLongDateString());

            // Comfirm
            Console.WriteLine("You Said you name is {0} and you are {1} years old?",name, age);

            Console.WriteLine();
            string reply = Accept_String_Info("reply (y/n): ");

            if ((reply == "y") || (reply == "Y"))
            {
                Console.WriteLine("Good Job boy");
            }
            else if ((reply == "n") || (reply == "N"))
            {
                Console.WriteLine("So why did you type Non-Sense before?");
            }
            else
            {
                Console.WriteLine("you no just get brain");
            }

        }

        private static void HelloWorld()
        {
            Console.WriteLine(" from method Hello World");
        }

        private static string Accept_String_Info(string message)
        {
            Console.Write(message);
            string reply = Console.ReadLine();
            return reply;
        }

    }
}
