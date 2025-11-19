using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class NormalVector
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public NormalVector(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            if(this != null)
            return $"Normal Vector: ({X};{Y};{Z})";
            else return "Vector is null";
        }

        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }


    }
}
