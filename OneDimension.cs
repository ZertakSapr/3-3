using System;
using System.Collections.Generic;
using System.Text;

namespace _3_3
{
    sealed class OneDimension : BaseClass, IOneDim
    {
        private int[] array;

        static private Random rnd = new Random();

        public int Lengthl
        {
            get
            {
                return array.Length;
            }
        }

        public int El(int number)
        {
            return array[number];
        }

        public void SwitchEl(int number, int amount)
        {
            array[number] = amount;
        }


        public OneDimension(int length, bool flag=false): base(flag)
        {
            array = new int[length];
            base.TypeOfInizialization();
        }

        protected override void UserFill()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент");
                array[i] = int.Parse(Console.ReadLine());
            }
        }


        protected override void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 101);
            }
        }

        public override  int Mid()
        {
            int sum = 0;
            for(int i=0; i<array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public override void Print()
        {
            string final = string.Join(" ", array);
            Console.WriteLine(final);

        }
        public void CleanMass()
        {
            int fl = 0;
            int count = 0;
            int[] arrayel = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == arrayel[j])
                    {
                        fl++;
                    }
                }
                if (fl < 1)
                {
                    arrayel[count] = array[i];
                    count++;
                }
                fl = 0;
            }
            int[] final = new int[count];
            for (int u = 0; u < final.Length; u++)
            {
                final[u] = arrayel[u];
            }
            Console.WriteLine("Не повторяющийся массив");
            for (int h = 0; h < final.Length; h++)
            {
                Console.WriteLine(final[h]);
            }
        }
    }
 }

