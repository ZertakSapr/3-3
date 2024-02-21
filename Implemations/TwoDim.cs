using System;
using System.Collections.Generic;
using System.Text;

namespace _3_3
{
    class TwoDim :BaseClass, ITwoDim
    {
        private int[,] array;

        static private Random rnd = new Random();
        public TwoDim( int RowCount, int CountColumn, bool Flag=false) : base(Flag)
        {
            array = new int[RowCount, CountColumn];
            base.TypeOfInizialization();

        }

        protected override void UserFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void RndFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);)
                {
                    array[i, j] = rnd.Next(-100, 101);
                }
            }
        }

        public override int Mid()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j=0; j<array.GetLength(1); j++)
                {
                    sum += array[i,j];
                }
            }
            Console.WriteLine("Среднее значение двумерных");
            return sum /( array.GetLength(0) * array.GetLength(1));
        }

        public override void Print()
        {
            Console.WriteLine("Массив двумерных");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string final = "";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    final += array[i, j]+" ";
                }
                Console.WriteLine(final);
            }
            
        }
        public void SnakeMatrice()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string final = "";
                if (i % 2 == 1)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                    {
                        final += array[i, j] + " ";
                    }

                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        final += array[i, j] + " ";
                    }

                }
                Console.WriteLine(final);
            }
        }
    }
}
