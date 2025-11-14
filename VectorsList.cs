using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class VectorsList
    {
        public List<NormalVector> vectors;
        public VectorsList()
        {
            vectors = new List<NormalVector>();
        }

        //Creates constructor that initializes the list with vectors using consturtor of class NormalVector with random data
        public VectorsList(int numberOfVectors)
        {
            vectors = new List<NormalVector>();
            Random rand = new Random();
            for (int i = 0; i < numberOfVectors; i++)
            {
                int x = rand.Next(-10, 11);
                int y = rand.Next(-10, 11);
                int z = rand.Next(-10, 11);
                vectors.Add(new NormalVector(x, y, z));
            }
        }

        public void AddVector(NormalVector vector)
        {
            vectors.Add(vector);
        }

        public void AddListofVectors(List<NormalVector> list)
        {
            vectors.AddRange(list);
        }

        public void RemoveVector(NormalVector vector)
        {
            vectors.Remove(vector);
        }

        public void ClearList()
        {
            vectors.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var vector in vectors)
            {
                sb.AppendLine(vector.ToString());
            }
            return sb.ToString();
        }

        public NormalVector GetVectorWithTheLargestLength()
        {
            return vectors.OrderByDescending(v => v.GetLength()).First();
        }


    }
}
