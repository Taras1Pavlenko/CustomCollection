using System;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] arr = { 1, 2,3,4,5,6,7,8,9,11,13,17};
            var pn = new PrimeNumbers(arr);
            foreach (var item in pn)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

    }
}
