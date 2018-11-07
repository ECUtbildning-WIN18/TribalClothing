using System;
using System.Threading;

namespace TribalClothing.ProductImporter.Domain
{
    public class StandardMessages
    {
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine("Action succeeded!");
            Thread.Sleep(1000);
        }
    }
}