using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelLib
{
    public class LevelType
    {
        public void Level(string getPath, string getType, string getMethod)
        {
            System.Reflection.Assembly levelLib = System.Reflection.Assembly.LoadFile(getPath);
            System.Type allLevelTypeClassRef = FindClass(levelLib, getType);
            Object objRef = System.Activator.CreateInstance(allLevelTypeClassRef);
            System.Reflection.MethodInfo methodRef = allLevelTypeClassRef.GetMethod(getMethod);
            if (getMethod == "Play")
            {
                object result = InvokeMethod(objRef, methodRef, new object[] { });
                Console.WriteLine(result.ToString());
            }
            else if (getMethod == "Start")
            {
                object result = InvokeMethod(objRef, methodRef, new object[] { "Navya" });
                Console.WriteLine(result.ToString());
            }
            else if (getMethod == "Begin")
            {
                object result = InvokeMethod(objRef, methodRef, new object[] { "Navya", 100 });
                Console.WriteLine(result.ToString());
            }
        }

        System.Type FindClass(System.Reflection.Assembly assemblyRef, String getType)
        {
            System.Type classType = assemblyRef.GetType(getType);
            if (classType != null)
            {
                if (classType.IsClass)
                {
                    return classType;
                }
            }
            return null;
        }

        object InvokeMethod(object source, System.Reflection.MethodInfo methodRef, object[] arguments)
        {
            return methodRef.Invoke(source, arguments);
        }
    }
}
