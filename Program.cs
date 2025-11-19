using System;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            try
            {
                Console.Write("Enter size of array: "); size = Convert.ToInt32(Console.ReadLine());
                if (size <= 0)
                {
                    throw new Exception("Size of array cannot be zero or less.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            VectorsList vectorsList = new VectorsList(size);

            Console.WriteLine("Vectors in the list:");

            Console.WriteLine(vectorsList.ToString());

            Console.WriteLine("Vector with the largest length");
            NormalVector largestVector = vectorsList.GetVectorWithTheLargestLength();
            if (largestVector != null) Console.WriteLine(largestVector.ToString());


        }
    }
}
