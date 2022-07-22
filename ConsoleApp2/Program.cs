using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


internal class Program
    {
        static void Main(string[] args)
        {
        // setup

        Random rnd = new Random();

        List<string> words = new List<String>();
        string filename = @"C:\Users\isaac\source\repos\ConsoleApp2\ConsoleApp2\words.txt";
        var lines = File.ReadLines(filename);
        foreach (var line in lines)
        {
            words.Add(line);
        }

        int r = rnd.Next(words.Count);

        String word = words[r];

        var currentGuess = new List<char>
        {
            '_',
            '_',
            '_',
            '_',
            '_'
        };

        int lives = 5;

        // the game
            while (lives > 0)
            {
                
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Lives: " + lives);
                foreach (char i in currentGuess)
                {
                    Console.Write(i);

                }
                Console.WriteLine();
                Console.WriteLine("Please, guess the word!");
                string Guess = Console.ReadLine();
                var characters = new List<char>();
                foreach (char i in Guess)
                {
                    
                    if (word.Contains(i))
                    {
                        int index = Guess.IndexOf(i);
                        if (index.Equals(word.IndexOf(i)))
                        {
                            if (characters.Contains(i))
                            {
                                Console.WriteLine(i + " is in the word, but not that spot");
                                characters.Add(i);
                                currentGuess[index] = i;

                        }
                            else
                            {
                                Console.WriteLine(i + " is correct!");
                                characters.Add(i);
                                currentGuess[index] = i;
                                
                            }
            
                        }
                        else
                        {
                            Console.WriteLine(i + " is in the word, but not that spot");
                            characters.Add(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine(i + " is incorrect!");
                        characters.Add(i);
                        
                    }
                }
                if (Guess == word)
                {
                    Console.WriteLine("Correct! " + word + " was the word!");
                    Console.ReadLine();
                }
                else
                {
                lives -= 1;
                continue;
                }
            }

        Console.WriteLine("Incorrect! The word was " + word);
        Console.ReadLine();
        }


    }



