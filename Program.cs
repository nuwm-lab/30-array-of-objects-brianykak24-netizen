using System;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            VectorsList vectorsList = new VectorsList(5);

            Console.WriteLine("Vectors in the list:");
            Console.WriteLine(vectorsList.ToString());

            Console.WriteLine("Vectoe with the largest length");
            NormalVector largestVector = vectorsList.GetVectorWithTheLargestLength();
            Console.WriteLine(largestVector.ToString());


        }
    }
}
