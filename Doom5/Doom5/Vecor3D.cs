using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doom5
{   
    class Vector3D
    {   
        double X, Y, Z;

        public Vector3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            return new Vector3D((a.X + b.X), (a.Y + b.Y), (a.Z + b.Z));
        }

        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            return new Vector3D((a.X - b.X), (a.Y - b.Y), (a.Z - b.Z));
        }

        public static Vector3D CrossProduct(Vector3D a, Vector3D b)
        {
            return new Vector3D(((a.Y * b.Z) - (a.Z * b.Y)),
                                ((a.Z * b.X) - (a.X * b.Z)),
                                ((a.X * b.Y) - (a.Y * b.X)));
        }

        public override string ToString()
        {
            return ("(" + X + "," + Y + "," + Z + ")");
        }
    }
}
