using System;

namespace Intro_01_10
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n \n \n Hello World!");
            int x = 125;
            Console.Write("X={0}", x);
            string name = "Dave ";
            Console.WriteLine("\n x={0} and name={1}", x, name);
            double myNumb = 3.14;

            Console.WriteLine("What is your name?-> ");
            string theName = Console.ReadLine();
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("What is your age or STOP to STOP-> ");
                String sAge = Console.ReadLine();
                String s2 = "STOP";
                if (string.Compare(sAge, "STOP") == 0) {
                    Console.Write("\nOK OK I WIll stop");
                    break;
                }

                Console.WriteLine("\n theName={0} and Age={1}", theName, sAge);

                int age = int.Parse(sAge);
                if (age >= 16 && age < 195)
                {
                    Console.Write("Yes you can drive");
                }
                else if (age >= 18 && age < 195)
                {
                    Console.Write("Yes you can vote");
                }
                else if (age >= 21 && age < 195)
                {
                    Console.Write("Yes you can Drink");
                }
                else
                {
                    Console.Write("You have no rights or you are not human");
                }
            }
        }

        }

    }
