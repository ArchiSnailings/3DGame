using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doom5
{
    class Vecor3D
    {
        double X, Y, Z;

        public Vecor3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Vecor3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }





        public static Vecor3D operator +(Vecor3D a, Vecor3D b)
        {

            return new Vecor3D((a.X + b.X), (a.Y + b.Y), (a.Z + b.Z));
        }

        public static Vecor3D operator -(Vecor3D a, Vecor3D b)
        {

            return new Vecor3D((a.X - b.X), (a.Y - b.Y), (a.Z - b.Z));
        }
    }
}
