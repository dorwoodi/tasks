using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_ticket
{
    class Program
    {
        static int Kolichestvo(int ch)
        {
            int kol = 0;
            while (ch > 0)
            {
                ch = ch / 10;
                kol++;
            }
            return kol;
        }
        static int Symma1(int kol, int ch)
        {
            int sum1 = 0;
            int pol = kol / 2;

            double a = ch / Math.Pow(10, pol);
            while (a > 0)
            {
                int b = (int)a % 10;
                sum1 = sum1 + b;
                a = a / 10;

            }


            return sum1;


        }
        static int Symma2(int kol, int ch)
        {
            int pol = kol / 2;
            int sum2 = 0;

            if (kol % 2 == 0)
            {
                while (pol > 0)
                {

                    int b = ch % 10;
                    sum2 = sum2 + b;
                    ch = ch / 10;
                    pol = pol - 1;

                }
            }
            else
            {
                pol = pol + 1;
                while (pol > 0)
                {

                    int b = ch % 10;
                    sum2 = sum2 + b;
                    ch = ch / 10;
                    pol = pol - 1;

                }

            }

            return sum2;
        }
        static bool Proverka(int sum1, int sum2)
        {
            bool vivod = sum1 == sum2;

            return vivod;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер вашего билета");
            int chislo = Convert.ToInt32(Console.ReadLine());


            int kol = Kolichestvo(chislo);
            Console.WriteLine("Количество цифр " + kol);

            int summa = Symma1(kol, chislo);
            Console.WriteLine("сумма1 " + summa);

            int summa2 = Symma2(kol, chislo);
            Console.WriteLine("сумма2 " + summa2);

            bool konec = Proverka(summa, summa2);
            Console.WriteLine(konec);






            Console.ReadKey();

        }
    }
}