using System;

namespace ProblemA
{
    class Kenshi : Murabito, IAttack
    {
        int attack;

        public Kenshi (int _hp, int _attack) : base(_hp)
        {
            attack = _attack;
        }

        public int Pattack
        {
            get { return attack; }
            set { attack = value; }
        }
    }
}
