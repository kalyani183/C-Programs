using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Argument
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of argument" + args.Length);
            Console.WriteLine("Arguments:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();

        }
    }
}
