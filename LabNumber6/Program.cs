using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Serena Tindle -- Lab#6
            bool ProgramContinue = true;

            while ( ProgramContinue == true)
            {

                Console.WriteLine("Welcome to the Pig Latin Translator");
                Console.WriteLine("Enter a line to be translated:"); //have user input a string
                string str = Console.ReadLine().ToLower(); //read input and convert to lowercase

                if (str.StartsWith("a") || str.StartsWith("e") || str.StartsWith("i") || str.StartsWith("o") || str.StartsWith("u"))
                {

                    Console.WriteLine(str + "way");
                }
                else
                {

                    char[] chars = { 'a', 'e', 'i', 'o', 'u' }; //declare and index char
                    int index = str.IndexOfAny(chars);
                    Console.WriteLine(str.Substring(index) + str.Substring(0, index) + "ay");
                    Console.WriteLine("Translate another line? (y/n):");//ask user if they want to continue or not
                    string UserChoice = Console.ReadLine();
                        if (UserChoice == "N" || UserChoice == "No" || UserChoice == "no" || UserChoice == "n")
                        {
                            ProgramContinue = false;
                        }
                    }
                  }
            }

        }
    }

