using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    internal class UIHelper
    {
        public static void DisplayAsciiArt()
        {

            // Set console text color for the logo
            Console.ForegroundColor = ConsoleColor.Magenta;

            // Path to ASCII text file inside Assets folder
            string path = "Assets/ascii.txt.txt";


            // Check if file exists before trying to read it
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("Cybersecurity Bot");
            }

            Console.ResetColor();
        }

        public static void PrintBot(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Bot: ");

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(15); // smoother typing
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        public static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=====================================");
            Console.ResetColor();
        }
    }
}
