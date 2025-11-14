using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class NormalVector
    {
        private int x, y, z;
        public NormalVector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Normal Vector: ({x};{y};{z})";
        }

        public double GetLength()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public int GetX() {return x;}
        public int GetY() { return y; }
        public int GetZ() { return z; }

    }
}
