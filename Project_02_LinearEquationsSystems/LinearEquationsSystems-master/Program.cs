using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_02_Linear_Equations_Systems
{
    class Program
    {
        static void Main(string[] args)
        {
            MainProgram();
            void MainProgram()
            {
                int id = 1;
                bool exitIfFalse = true;
                string userInput;
                Matrix matrix = new Matrix();

                Console.WriteLine("Type linear equations in augmented matrix notation: a1 a2 ... aN d,\n        where a1 ... are parameters and d is constant");
                Console.WriteLine("\nType END to finish entering equations\n");

                while (exitIfFalse)
                {
                    Console.Write($"Eq #{id}: ");
                    userInput = Console.ReadLine();
                    if (userInput == "END")
                    {
                        break;
                    }
                    else if (new Equation(userInput).CheckEquation() && !string.IsNullOrEmpty(userInput))
                    {
                        matrix.AddEquation(userInput);
                        id++;
                    }
                }

                Console.Clear();
                Console.WriteLine("You have entered the following equations:");

                matrix.ShowEquations();
                Console.WriteLine("\nAnswers:");
                matrix.Solve();
                matrix.ShowAnswers();
                LoopOfMainProgram();

               
            }
            void LoopOfMainProgram()
            {
                while (true)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear(); MainProgram(); break;
                }
            }

        }
    }
}
