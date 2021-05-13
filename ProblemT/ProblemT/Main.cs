using System;

namespace ProblemT
{
    class ProblemT
    {
        static void Main()
        {
            BaseSlot a = null;

            // Slot選択
            Console.WriteLine("Select Slot : ");
            char slot = Char.Parse(Console.ReadLine());
            Console.WriteLine("Credit : ");
            float credit = float.Parse(Console.ReadLine());

            if (slot == 'A')
            {
                a = new SlotA(credit);
                while (true)
                {
                    Console.WriteLine("Do or End ?");
                    string line = Console.ReadLine();
                    if (line == "Do")
                    {
                        A.Do();
                    }
                }
            }
        }
    }

}
