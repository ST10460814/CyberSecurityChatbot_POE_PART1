using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    internal class AudioPlayer
    {
      
            public static void PlayGreeting()
            {

            // Path to the audio file inside the Assets folder
            string path = "Assets/greeting.wav";


            // This prevents the program from crashing if the file is missing
            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            else
            {
                System.Console.WriteLine("Audio file not found.");
            }
        }
    }
    }

