using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class VectorsList
    {
        private readonly NormalVector[] vectors;
        public VectorsList()
        {
            vectors = new NormalVector[0];
        }

        public VectorsList(int numberOfVectors)
        {
            vectors = new NormalVector[numberOfVectors];
            Random rand = new Random();
            for (int i = 0; i < numberOfVectors; i++)
            {
                vectors[i] = new NormalVector(rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10));
            }
        }

        public void AddVector(NormalVector vector)
        {
            vectors.Append(vector);
        }

        public void AddRange(List<NormalVector> list)
        {
            foreach (var vector in list)
            {
                vectors.Append(vector);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < vectors.Length; i++)
            {
                sb.AppendLine(vectors[i].ToString());
            }
            return sb.ToString();
        }

        public NormalVector GetVectorWithTheLargestLength()
        {
            try
            {

                if (vectors.Length != 0)
                {

                }
                int tmp = 0;
                var value = vectors[0].GetLength();
                for (int i = 0; i < vectors.Length; i++)
                {
                    if (value > vectors[i].GetLength()) tmp = i;
                }
                return vectors[tmp];
            }
            catch
            {
                throw new InvalidOperationException("The list is empty");
            }
        }


    }
}
