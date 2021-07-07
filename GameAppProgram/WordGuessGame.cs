using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppProgram
{
    public enum Options
    {
        BASIC = 1, INTERMEDIATE = 10, ADVANCED
    }
    class WordGuessGame
    {
        public void StartGame(Options _choice)
        {
            if (_choice != Options.BASIC && _choice != Options.INTERMEDIATE && _choice != Options.ADVANCED)
            {
                Console.WriteLine("Please enter valid number");
                
            }
            else
            {
                switch (_choice)
                {

                    case Options.BASIC:
                        Console.WriteLine("Basic Level");
                        break;
                    case Options.INTERMEDIATE:
                        Console.WriteLine("Intermediate Level");
                        break;
                    case Options.ADVANCED:
                        Console.WriteLine("Advanced Level");
                        break;
                }
            }

        }
    }
}
