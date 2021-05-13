using System;

namespace ProblemT
{
    abstract class BaseSlot
    {
        protected float credit;

        protected Random r = new System.Random();

        public abstract bool Do();

        public void GetPrize ()
        {
            Console.WriteLine((int)credit);
        }

        public BaseSlot (float _credit)
        {
            credit = _credit;
        }
    }

    class SlotA : BaseSlot
    {
        public override bool Do()
        {
            if (credit == 0)
            {
                return false;
            }

            if (r.Next(0, 100) < 50)
            {
                credit *= 1.5f;
            }
            else
            {
                credit *= 0.5f;
            }

            return true;
        }


        public SlotA(float credit): base(credit)
        {
        }
    }

    class SlotB : BaseSlot
    {
        public override bool Do()
        {
            if (credit == 0)
            {
                return false;
            }

            if (r.Next(0, 100) < 90)
            {
                credit *= 1.1f;
            }
            else
            {
                credit = 0;
            }
            return true;
        }
    }

    class SlotC : BaseSlot
    {
        public override bool Do()
        {
            if (credit < 10)
            {
                return false;
            }

            credit -= 10;
            if (r.Next(0, 100) < 50)
            {
                credit *= 2f;
            }
            else
            {
                credit *= 0.5f;
            }
            return true;
        }
    }
}
