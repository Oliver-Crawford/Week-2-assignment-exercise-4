using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_assignment_exercise_4
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            /*Write an application which let user input random letters until user input 0.
            * Then, the application will print out the list of letters associates which how many times they are input. */
            Dictionary<string, int> characters = new Dictionary<string, int>();
            bool done = false;
            bool checkDone = false;
            string tempStr = "";
            Console.WriteLine("Input characters, input 0 to end");
            while (!done)
            {
                Console.Write("Please input a single Character: ");
                while (!checkDone)
                {
                    tempStr = Console.ReadLine();
                    if(tempStr.Length > 1 || tempStr.Length < 1)
                    {
                        Console.Write("Invalid input, try again: ");
                    } else
                    {
                        checkDone = true;
                    }
                }
                checkDone = false;
                if(tempStr != "0")
                {
                    try
                    {
                        characters.Add(tempStr, 1);
                    } catch
                    {
                        characters[tempStr] += 1;
                    }
                } else
                {
                    done = true;
                }
            }
            Console.WriteLine("Characters : Times Written");
            foreach(string i in characters.Keys)
            {
                Console.WriteLine($"{i} : {characters[i]}");
            }
            Console.ReadLine();
        }
    }
}
