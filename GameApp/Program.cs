using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public enum Options
    {
        BASIC = 1, INTERMEDIATE, ADVANCED
    }

   
        class Program
        {
            static void Main(string[] args)
            {
            int count = 3;
            do
            {
                Console.WriteLine("Word Guess Game");
                string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
                Console.WriteLine(displayMessage);

                try
                {
                    Options _choice = (Options)Int32.Parse(Console.ReadLine());

                    LevelLib.LevelType levelType = new LevelLib.LevelType();

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
                                levelType.Level(@"C:\Users\navyashrees\Documents\GitHub\latebinding-using-reflection-navyashrees29\GameApp\bin\Debug\LevelLibs\BasicLevelLib.dll", "BasicLevelLib.BasicLevelType", "Play");
                                break;

                            case Options.INTERMEDIATE:
                                Console.WriteLine("Intermediate Level");
                                levelType.Level(@"C:\Users\navyashrees\Documents\GitHub\latebinding-using-reflection-navyashrees29\GameApp\bin\Debug\LevelLibs\IntermediateLevelLib.dll", "IntermediateLevelLib.IntermediateLevelType", "Start");
                                break;

                            case Options.ADVANCED:
                                Console.WriteLine("Advanced Level");
                                levelType.Level(@"C:\Users\navyashrees\Documents\GitHub\latebinding-using-reflection-navyashrees29\GameApp\bin\Debug\LevelLibs\AdvancedLevelLib.dll", "AdvancedLevelLib.AdvancedLevelType", "Begin");
                                break;
                        }
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Enter integer value");
                }
                --count;
            } while (count > 0);
        }
    }
}
