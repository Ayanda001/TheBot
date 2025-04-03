using System;
using System.Drawing;

namespace TheBot
{
    public class LogoDisplay
    {
        


        //The  method is  to display the updated ASCII Art logo(image) of the chat bot
        public static void DisplayAsciiArtLogo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
 
 __       __                                                 ________ __                        _______               __     
/  \     /  |                                               /        /  |                      /       \             /  |    
$$  \   /$$ |  ______    _______  _______  ______           $$$$$$$$/$$ |____    ______        $$$$$$$  |  ______   _$$ |_   
$$$  \ /$$$ | /      \  /       |/       |/      \             $$ |  $$      \  /      \       $$ |__$$ | /      \ / $$   |  
$$$$  /$$$$ | $$$$$$  |/$$$$$$$//$$$$$$$/ $$$$$$  |            $$ |  $$$$$$$  |/$$$$$$  |      $$    $$< /$$$$$$  |$$$$$$/   
$$ $$ $$/$$ | /    $$ |$$      \$$      \ /    $$ |            $$ |  $$ |  $$ |$$    $$ |      $$$$$$$  |$$ |  $$ |  $$ | __ 
$$ |$$$/ $$ |/$$$$$$$ | $$$$$$  |$$$$$$  /$$$$$$$ |__          $$ |  $$ |  $$ |$$$$$$$$/       $$ |__$$ |$$ \__$$ |  $$ |/  |
$$ | $/  $$ |$$    $$ |/     $$//     $$/$$    $$ /  |         $$ |  $$ |  $$ |$$       |      $$    $$/ $$    $$/   $$  $$/ 
$$/      $$/  $$$$$$$/ $$$$$$$/ $$$$$$$/  $$$$$$$/$$/          $$/   $$/   $$/  $$$$$$$/       $$$$$$$/   $$$$$$/     $$$$/  

                                                                                                                             
 @ 2025 Massa. The Cyber-Security Assistant Bot 9.0                                                                                                           
         ");
            Console.ResetColor();
        }//end of display ascii logo
         //End of method one

    } //end of logo display
} //end of namespace
