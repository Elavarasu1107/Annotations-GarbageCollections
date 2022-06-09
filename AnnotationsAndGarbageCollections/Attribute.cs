using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Annotations_GarbageCollections
{
    public class NewAttribute : Attribute
    {
        string title;
        string description;
        public NewAttribute(string t,string d)
        {
            this.title = t;
            this.description = d;
        }
        public static void printAtteributes(Type type)
        {
            Console.WriteLine("Atteribute in {0} are", type.Name);
            MethodInfo[] methodInfo = type.GetMethods();
            for (int i=0;i<methodInfo.Length;i++)
            {
                object[] atteributeArray = methodInfo[i].GetCustomAttributes(true);
                foreach(Attribute items in atteributeArray)
                {
                    if (items is NewAttribute)
                    {
                        NewAttribute atteributeObj = (NewAttribute)items;
                        Console.WriteLine("{0},{1},{2}", methodInfo[i].Name, atteributeObj.title, atteributeObj.description);
                    }
                }
                
            }
        }
    }
}
