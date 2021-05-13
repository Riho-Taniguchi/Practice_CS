using System;

namespace ProblemA
{
    class Mahoutsukai : Murabito, IMP
    {
        int mp;

        public Mahoutsukai(int _hp, int _mp) : base(_hp)
        {
            mp = _mp;
        }

        public int Pmp
        {
            get { return mp; }
            set { mp = value; }
        }
    }
}
