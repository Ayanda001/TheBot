using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TheBot
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Firstly the program will diplay ASCII image
               new ASCIIImage() { };
               ASCIIImage.Display();

            //Secondly the program will display the Logo
               new LogoDisplay() { };
               LogoDisplay.DisplayAsciiArtLogo();
            
            //Thirdly the program will start to play audio sound
               new AudioPlayer() {  };
               AudioPlayer.PlayVoiceGreeting("ai.record.wav");

            // Lastly the bot will start to interact with the user and the awareness of cybersecurity
              ChatBotInteraction chatBot = new ChatBotInteraction();
             chatBot.StartChat();
             new ChatBotInteraction() { };
          
        } //end of main
        }//end of class program
    }//end of namespace cybersecurity assistance

//This code was done by Ayanda Maseko.