using System;

namespace Recursive
{
    class Program
    {
       
        public static void CountDown(int startNumber)
        {
            Console.WriteLine(startNumber);
            if (startNumber == 0) return;
            startNumber--;
            CountDown(startNumber);
        }
        static void Main(string[] args)
        {
            int numero = 30;
            CountDown(numero);
        }
    }
}
