using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletone1 = Singleton.Instance();
            Singleton singletone2 = Singleton.Instance();

            if (singletone1 == singletone2)
            {
                Console.WriteLine("Two Are Same.");
            }

            Console.ReadKey();
        }
    }
}
