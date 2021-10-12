using System;

namespace HomeTaskDeligate
{
    class Program
    {
        public static void Main()
        {
            Generic<int> gnr1 = new Generic<int>(YoxlamaMetodu);
            gnr1.Invoke(101);

        }
        public delegate void Generic<T>(T n);

        public static void YoxlamaMetodu(int num)
        {
            if (num > 0)
            { Console.WriteLine("eded musbetdir"); }
            else
            { Console.WriteLine("eded menfidir"); }
            if (num % 2 == 0)
            { Console.WriteLine("eded cutdur"); }
            else
            { Console.WriteLine("eded tekdir"); }
            if (num % 2 == 0 || num % 3 == 0)
            { Console.WriteLine("eded murekkebdir"); }
            else
            { Console.WriteLine("eded sadedir"); }
        }
    }
}
