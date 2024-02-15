using System;
using System.Collections.Generic;
using System.Text;

namespace _3_3
{
    abstract class BaseClass : IBaseInterface
    {
        private bool flag { get; set; }

        protected BaseClass(bool Flag)
        {
            flag = Flag;
        }
        public abstract int Mid();
        public abstract void Print();

        protected abstract void UserFill();
        protected abstract void RndFill();


        protected void TypeOfInizialization()
        {
            if (flag)
            {
                UserFill();

            }
            else
            {
                RndFill();
            }
        }
    }
}
