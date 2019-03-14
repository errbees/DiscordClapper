using System;

namespace DiscordClapper
{
    class Program
    {
        static void Main(string[] args)
        {

            string output = "";

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    output += " :clap: ";
                }
                else output += input[i];
            }

            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
