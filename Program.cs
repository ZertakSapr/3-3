using System;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter[] mass = new IPrinter[4];
            IBaseInterface[] mass1 = new IBaseInterface[3];
            Console.WriteLine("Как вы хотите заполянть массив одномерных");
            bool flagone = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во злементов вы хотите в одномерном масииве");
            int count = int.Parse(Console.ReadLine());
            if (flagone)
            {
                OneDimension One = new OneDimension(count, flagone);
                mass[0] = One;
                mass1[0] = One;
                One.CleanMass();
            }
            else
            {
                OneDimension One = new OneDimension(count);
                mass[0] = One;
                mass1[0] = One;
                One.CleanMass();
            }


            Console.WriteLine("Как вы хотите заполянть массив двумерных");
            bool flagtwo = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во строк вы хотите в двумерном масииве");
            int counttwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во столбцов вы хотите в двумерном масииве");
            int counttwoс = int.Parse(Console.ReadLine());

            if (flagtwo)
            {
                TwoDim two = new TwoDim(counttwo, counttwoс, flagtwo);
                mass[1] = two;
                mass1[1] =two;
                two.SnakeMatrice();
            }
            else
            {
                TwoDim two = new TwoDim(counttwo, counttwoс);
                mass[1] = two;
                mass1[1] = two;
                two.SnakeMatrice();
            }

            Console.WriteLine("Как вы хотите заполянть массив ступенчатых");
            bool flagst = bool.Parse(Console.ReadLine());
            Console.WriteLine("Каок кол-во строк вы хотите в ступенчатом масииве");
            int countst = int.Parse(Console.ReadLine());

            if (flagst)
            {
                StepDim st = new StepDim(countst, flagst);
                mass[2] = st;
                mass1[2] = st;
                st.SwitchedEl();
            }
            else
            {
                StepDim st = new StepDim(countst);
                mass[2] = st;
                mass1[2] = st;
                st.SwitchedEl();
            }
            mass[3] = new Week();
            for (int i = 0; i < mass.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Весь массив одномерных");
                }
                mass[i].Print();

            }
            for (int i = 0; i < mass1.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Среднее значение одномерных");
                    
                }
                Console.WriteLine(mass1[i].Mid());

            }
        }
    }
}
