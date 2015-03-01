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
            Vector3D a = new Vector3D(0, 2, 3);
            Vector3D b = new Vector3D(0, 3, 2);

            Vector3D c = Vector3D.CrossProduct(a, b)+b;


            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
