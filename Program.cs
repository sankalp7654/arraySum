
// @author - Sankalp Saxena
 

using System;
namespace ArraySum
{
	public class ArraySum
	{
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of elements ");
                long arraySize = long.Parse(Console.ReadLine());
                long[] array = new long[arraySize];
                long sum = 0L;

                Console.WriteLine("Enter {0} elements", arraySize);

                for (int i = 0; i < arraySize; i++)
                {
                    array[i] = long.Parse(Console.ReadLine());
                    sum += array[i];
                }

                Console.WriteLine("Array you entered  ");

                for (int i = 0; i < arraySize; i++){
					Console.WriteLine("{0}  ", array[i]);
                }
                    

                Console.WriteLine("Sum of elements of above array is {0}", sum);

            }
            catch (Exception)
            {
                Console.WriteLine("INVALID FORMAT");
            }
        }
	}
}
