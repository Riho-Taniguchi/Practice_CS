using System;

namespace ProblemA
{
    class Program
    {
        static void Main()
        {
            Murabito murabito1 = new Murabito(20);
            murabito1.print_hp();

            Yusya yusya = new Yusya(50, 50, 50);
            yusya.print_hp();
            Console.WriteLine("Yusya Attack = " + yusya.Pattack);
        }
    }
}
