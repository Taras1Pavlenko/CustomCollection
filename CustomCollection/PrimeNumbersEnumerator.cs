using System;
using System.Collections;

namespace CustomCollection
{
    class PrimeNumbersEnumerator : IEnumerator
    {
        private readonly int[] array;
        private int position = -1;

        public PrimeNumbersEnumerator(int[] array)
        {
            this.array = array;
        }

        public object Current
        {
            get
            {
                return array[position];
            }
        }


        public bool MoveNext()
        {
            if (position < array.Length-1)
            {
                position++;
            }
            else
            {
                return false;
            }
            return IsPrimeNumber(array[position]);

        }


        public void Reset()
        {
            position = -1;
        }

        private bool IsPrimeNumber(int v)
        {
            bool flag = true;
            if (position < array.Length)
            {
                while (!CheckPrime(array[position]))
                {
                    if (position < array.Length - 1)
                    {
                        position++;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                return flag;
            }
            else
            {
                return false;
            }
        }
        private bool CheckPrime(int number)
        {
            var boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number < 2)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }


            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
