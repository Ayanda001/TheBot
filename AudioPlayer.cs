using System.Media;
using System;

namespace TheBot
{
    public class AudioPlayer
    {
       

        //The second method is to play the audio greeting by passing it through a file path

        public static void PlayVoiceGreeting(string filePath)
        {

            try
            {
                // Initialize the SoundPlayer object with the file path provided as an argument  
                using (SoundPlayer Play = new SoundPlayer(filePath))
                {
                    // Play the sound synchronously (the method blocks until the audio finishes playing)
                    Play.PlaySync();
                }
            }//end of try
            catch (Exception error)
            {
                // Show the error message if audio doesn't play
                Console.WriteLine("Error playing audio: " + error.Message);
            }//end of catch
        }//end of play voice greeting method

    } //end of audioo player
    } //end of namespace
