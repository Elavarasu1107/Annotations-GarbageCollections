using System;
using Annotations_GarbageCollections;

namespace Annotations_GarbageCollections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Annotations and \n2 for Garbage Collections\nEnter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    {
                        NewAttribute.printAtteributes(typeof(Students));
                        Console.WriteLine();
                        NewAttribute.printAtteributes(typeof(Teachers));
                        Console.WriteLine();
                        break;
                    }
                case 2:
                    {
                        DisposableResourceHolder disposableResourceHolder = new DisposableResourceHolder();
                        disposableResourceHolder.Dispose();
                        //GarbageCollection garbageCollection = new GarbageCollection();
                        //garbageCollection.Collector();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid Number");
                        break;
                    }
            }
        }
    }
}



