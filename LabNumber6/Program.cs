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

            while (ProgramContinue == true)
            {

                Console.WriteLine("Welcome to the Pig Latin Translator");
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
                    string UserChoice = ValidateString(); //call validation method
                    if (UserChoice == "no")
                    {
                        ProgramContinue = false;
                    }


                }
            }
        }

        public static string ValidateString()
        {

            bool Validate = true;
            string UserInput="";
            while (Validate == true)
            {
              UserInput = (Console.ReadLine());
                if (UserInput != "yes" && UserInput != "no")
                {
                    Console.WriteLine("Please enter yes or no!");
                }
                else
                    Validate = false;
            }
            return UserInput;
        }

    }
}


