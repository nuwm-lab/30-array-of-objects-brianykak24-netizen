using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class NormalVector
    {
        public int x { get; }
        public int y { get; }
        public int z { get; }
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


    }
}
