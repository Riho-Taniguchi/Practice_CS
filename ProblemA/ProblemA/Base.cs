using System;

namespace ProblemA
{
    class Murabito
    {
        protected int hp;

        public Murabito(int _hp)
        {
            hp = _hp;
        }

        public void print_hp ()
        {
            Console.WriteLine("hp = " + hp);
        }
    }

    interface IAttack
    {
        int Pattack { get; set; }
    }

    interface IMP
    {
        int Pmp { get; set; }
    }
}
