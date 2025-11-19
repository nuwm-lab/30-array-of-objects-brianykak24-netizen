using System;
using System.Linq;
using System.Text;

namespace LabWork
{
    public class VectorsList
    {
        private readonly NormalVector[] _vectors;
        public VectorsList()
        {
            _vectors = new NormalVector[0];
        }

        //Creates constructor that initializes the list with vectors using consturtor of class NormalVector with random data
        public VectorsList(int numberOfVectors)
        {
            _vectors = new NormalVector[numberOfVectors];
            Random rand = new Random();
            for (int i = 0; i < numberOfVectors; i++)
            {
                int x = rand.Next(-10, 11);
                int y = rand.Next(-10, 11);
                int z = rand.Next(-10, 11);
                _vectors[i] = (new NormalVector(x, y, z));
            }
        }

        public override string ToString()
        {
            if(_vectors.Length == 0)
            {
                return "Vectors list is empty.";
            }
            StringBuilder sb = new StringBuilder();
            foreach (var vector in _vectors)
            {
                sb.AppendLine(vector.ToString());
            }
            return sb.ToString();
        }

        public NormalVector GetVectorWithTheLargestLength()
        {
            if (_vectors.Length == 0) return null;
            return _vectors.MaxBy(x => x.GetLength());
        }


    }
}