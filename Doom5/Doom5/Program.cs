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
            Vector3D a = new Vector3D(1, 4, 5);
            Vector3D b = new Vector3D(3, 2, 3);

            Vector3D c = a+b;

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
