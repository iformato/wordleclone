using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String word = "plank";


            while (true)
            {
                Console.WriteLine("Please, guess the word!");
                string Guess = Console.ReadLine();
                foreach (char i in Guess)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(Guess.IndexOf(i));
                    Console.WriteLine(word.IndexOf(i));
                    if (word.Contains(i))
                    {
                        if (Guess.IndexOf(i).Equals(word.IndexOf(i)))
                        {
                            Console.WriteLine(i + " is correct!");
                        }
                        else
                        {
                            Console.WriteLine(i + " is in the word, but not that spot");
                        }
                    }
                    else
                    {
                        Console.WriteLine(i + " is incorrect!");
                        continue;
                    }
                }

            }
        }


    }
}


