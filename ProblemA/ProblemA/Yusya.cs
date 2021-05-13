using System;

namespace ProblemA
{
    class Yusya : Murabito, IAttack, IMP
    {
        int attack;
        int mp;

        public Yusya(int _hp, int _attack, int _mp) : base(_hp)
        {
            attack = _attack;
            mp = _mp;
        }

        public int Pattack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Pmp
        {
            get { return mp; }
            set { mp = value; }
        }
    }
}
