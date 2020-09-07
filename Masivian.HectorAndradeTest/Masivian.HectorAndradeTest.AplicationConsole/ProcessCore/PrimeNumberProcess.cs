using HectorAndradeTest.AplicationConsole.Entities;
using System.Collections.Generic;

namespace HectorAndradeTest.AplicationConsole.ProcessCore
{
    public static class PrimeNumberProcess
    {
        public static bool IsNumberPrime(int _number)
        {
            for (int i = 2; i < _number; i++)
            {
                if (_number % i == 0 && i != _number)
                    return false;
            }
            return true;
        }

        public static List<int> GetListNumbersPrime()
        {
            int number = 0;
            List<int> listNumberPrime = new List<int>();
            while (listNumberPrime.Count < ConfigurationData.ItemCount)
            {
                number = NumberPrimeSearch(number);
                listNumberPrime.Add(number);
            }
            return listNumberPrime;
        }

        public static int NumberPrimeSearch(int _number)
        {
            bool isPrime;
            do
            {
                _number++;
                isPrime = PrimeNumberProcess.IsNumberPrime(_number);
            } while (!isPrime);
            return _number;
        }
    }
}
