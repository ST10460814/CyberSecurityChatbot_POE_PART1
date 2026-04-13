using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    internal class InputHandler
    {
        public static string GetValidName()
        {

            // Variable to store user input
            string name;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your name: ");
                Console.ResetColor();

                // Read user input from console
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name cannot be empty.");
                    Console.ResetColor();
                }
                else
                {
                    return name;
                }
            }
        }
    }
}
