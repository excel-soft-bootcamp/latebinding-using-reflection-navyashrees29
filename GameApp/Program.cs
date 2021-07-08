using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
 
    public enum Options
    {
        BASIC=1,INTERMEDIATE,ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleDisplay consoleDisplay = new ConsoleDisplay();
            consoleDisplay.Display();

            ValidateUserInputs validateUserInputs = new ValidateUserInputs();
            Options value= validateUserInputs.ValidateInputs();

            CheckSwitchCondition checkCondition = new CheckSwitchCondition();
            checkCondition.SwitchCondition(value);
        }
    }
}
