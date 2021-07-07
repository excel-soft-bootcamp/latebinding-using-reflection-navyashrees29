using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppProgram
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Guess Game");
            string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
            Console.WriteLine(displayMessage);
            Options _choice = (Options)Int32.Parse(Console.ReadLine());

            WordGuessGame game = new WordGuessGame();
            game.StartGame(_choice);

        }
    }
}
