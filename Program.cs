using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Bailey");
            int a = 3 + 4;
            Console.WriteLine(a);

            int b = 7 - 3;
            Console.WriteLine(b);

            int c = 3;
            Console.WriteLine(c++);
            Console.WriteLine(c--);

            string name = "Me";
            Console.WriteLine(name);

            bool myBool = false;
            Console.WriteLine(myBool);

            char firstLetter = 'z';
            Console.WriteLine(firstLetter);

            double pi = 3.14;
            Console.WriteLine(pi);
                string pathChoice;
            do
            {

                Console.WriteLine("Choose a path. Rigth or Left.");

                pathChoice = Console.ReadLine();
                if (pathChoice.ToLower() == "right")
                {
                    Console.WriteLine("Nice.");
                }
                else if (pathChoice.ToLower() == "left")
                {
                    Console.WriteLine("Try again.");
                }
                else
                {
                    Console.WriteLine("Nice try bub");
                }

            } while (pathChoice != "right");

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            string[] pokemons = { "Bulbasaur", "Charmander", "Squirtle" };
            foreach(string pokemon in pokemons)
            {
                Console.WriteLine(pokemon);
            }

            string response = "no";
            while (response != "yes")
            {
                Console.WriteLine("Please say yes.");
                response = Console.ReadLine();
            }



            
        }
    }
}
