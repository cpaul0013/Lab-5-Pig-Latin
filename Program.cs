using System;

namespace Pig_Latin_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translaor.");
            bool runProgram = true;
            while (runProgram == true)
            {
                bool containsNoSpecial = false;
                Console.WriteLine("Please enter a word.");
                string userInput = Console.ReadLine();               
                    containsNoSpecial = noSpecials(userInput);
                    if(containsNoSpecial == true)
                {
                    Console.WriteLine(PigLatinTranslator(userInput));
                }
                    else
                {   while (containsNoSpecial == false)
                    {
                        Console.WriteLine("Please enter a word with no special characters or spaces");
                        Console.WriteLine("Please enter a word: ");
                        userInput = Console.ReadLine();
                        containsNoSpecial = noSpecials(userInput);
                        if(containsNoSpecial == true)
                        {
                            Console.WriteLine(PigLatinTranslator(userInput));
                        }
                        else
                        {
                            containsNoSpecial = false;
                        }

                    }       
                }                                                                       
                bool validInput = false;
                while (validInput == false)
                {
                    Console.WriteLine("Would you like to translate another word? Y / N");
                    string response = Console.ReadLine();
                    response = response.ToLower();
                    if (response == "y" || response == "n")
                    {
                        validInput = true;
                        if (response == "y")
                        {
                            runProgram = true;
                        }
                        else if (response == "n")
                        {
                            runProgram = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please input a valid letter.");
                        validInput = false;

                    }
                }
            }
        }

        public static string PigLatinTranslator(string x)
        {
            x = x.ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char y in vowels)
            {
                if (y == x[0])
                {

                    return x + "way";
                }
            }
            int position = x.IndexOfAny(vowels);
            x = x.Substring(position) + x.Substring(0, position) + "ay";
            return x;     
        }

        public static bool noSpecials(string x)
        {
            bool noSpecials = true;
            foreach(char c in x)
            {    
                if(c >= 65 && c <= 122)
                {
                    noSpecials = true;
                    
                }
                else
                {
                    noSpecials = false;
                    break;
                }
            }
            return noSpecials;
        }

    }
}
    

