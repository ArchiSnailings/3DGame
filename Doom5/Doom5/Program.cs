using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doom5
{
    class Program
    {
        public static void Main()
        {
            Vecor3D a = new Vecor3D(1, 4, 5);
            Vecor3D b = new Vecor3D(3, 2, 3);

            Vecor3D c = a+b;

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
