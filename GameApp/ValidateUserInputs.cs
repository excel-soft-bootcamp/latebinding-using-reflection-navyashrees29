using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class ValidateUserInputs
    {
        public int count = 0;
        public Options _choice;
        public Options ValidateInputs()
        {
            count++;
            if(count<=3)
            {
                try
                {
                    _choice = (Options)Int32.Parse(Console.ReadLine());
                    if (_choice != Options.BASIC && _choice != Options.INTERMEDIATE && _choice != Options.ADVANCED)
                    {

                        Console.WriteLine("Please Enter Valid Number");
                        ValidateInputs();
                    }
                }
                catch
                {
                    Console.WriteLine("Please Enter Integer Value");
                    ValidateInputs();
                }
            } 
            return _choice;
        }
    }
}
