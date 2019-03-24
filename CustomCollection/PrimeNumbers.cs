using System.Collections;

namespace CustomCollection
{
    class PrimeNumbers : IEnumerable
    {
        private readonly int[] array;

        public PrimeNumbers(int[] array)
        {
            this.array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return new PrimeNumbersEnumerator(this.array);
        }
    }

}
