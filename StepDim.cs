using System;
using System.Collections.Generic;
using System.Text;

namespace _3_3
{
    class StepDim:BaseClass, IStepDim
    {
        OneDimension[] array;
        public StepDim(int Length, bool Flag = false) : base(Flag)
        {
            array = new OneDimension[Length];
            base.TypeOfInizialization();
        }


        protected override void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите кол во элементов в строке ступенчатых");
                int length = int.Parse(Console.ReadLine());
                array[i] = new OneDimension(length, true);


            }
        }


        protected override void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите кол во элементов в строке ступенчатых");
                int length = int.Parse(Console.ReadLine());
                array[i] = new OneDimension(length);

            }
        }


        public override int Mid()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i].Mid();
            }
            Console.WriteLine("Среднее значение ступенчатых");
            return sum / array.Length;

        }


        public override void Print()
        {
            Console.WriteLine("весь массив ступенчатых");
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Print();
            }
        }

        public void SwitchedEl()
        {
            OneDimension[] arraysw = array;
            for (int i = 0; i < arraysw.Length; i++)
            {
                for (int j = 0; j < arraysw[i].Lengthl; j++)
                {
                    if (arraysw[i].El(j) % 2 == 0)
                    {
                        arraysw[i].SwitchEl(j, i * j);
                    }
                }
                arraysw[i].Print();
            }
        }
    }
}
