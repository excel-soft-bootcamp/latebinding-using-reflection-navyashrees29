using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class CheckCondition
    {
         public CheckCondition(string path, string getType, string getMethod )
         {
            System.Reflection.Assembly assemblyLevelLib =System.Reflection.Assembly.LoadFile(path);
            System.Type ClassRef = assemblyLevelLib.GetType(getType);
            if (ClassRef != null)
            {
                if (ClassRef.IsClass)
                {
                    Object objRef = System.Activator.CreateInstance(ClassRef);
                    System.Reflection.MethodInfo methodRef = ClassRef.GetMethod(getMethod);
                    if (!methodRef.IsStatic)
                    {
                        object result = methodRef.Invoke(objRef, new object[] { });
                        Console.WriteLine(result.ToString());
                    }

                }
            }
         }
    }
}
