using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // PLAY GREETING AUDIO (WELCOME SOUND)
            // This plays a voice greeting when the program starts
            AudioPlayer.PlayGreeting();


           
            // DISPLAY ASCII ART LOGO
            // This shows the chatbot branding/logo in the console
            UIHelper.DisplayAsciiArt();

            // This improves UI readability and separates sections
            UIHelper.PrintDivider();

            // CREATES CHATBOT OBJECT
            Chatbot bot = new Chatbot();
            bot.StartChat();

            Console.ReadKey();
        }
    }
}
