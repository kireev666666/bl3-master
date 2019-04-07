using System;

namespace B_3_Operators
{
    class Program
    {
        static void Main()
        {
            Lesson.Examples();

            Console.WriteLine("Сумма кредита");
            double Summa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Проценты");
            double Percent = Convert.ToDouble(Console.ReadLine());
            double month1, month2, month3, month4, month5, month6, month7, month8, month9, month10, month11, month12;
            month1 = Summa/12 + (Summa * Percent/100/12);
            month2 = Summa / 12 + ((Summa - month1) * Percent/100/12);
            month3 = Summa / 12 + ((Summa - month2) * Percent/100/12);
            month4 = Summa / 12 + ((Summa - month3) * Percent/100/12);
            month5 = Summa / 12 + ((Summa - month4) * Percent/100/12);
            month6 = Summa / 12 + ((Summa - month5) * Percent/100/12);
            month7 = Summa / 12 + ((Summa - month6) * Percent/100/12);
            month8 = Summa / 12 + ((Summa - month7) * Percent/100/12);
            month9 = Summa / 12 + ((Summa - month8) * Percent/100/12);
            month10 = Summa / 12 + ((Summa - month9) * Percent/100/12);
            month11 = Summa / 12 + ((Summa - month10) * Percent/100/12);
            month12 = Summa / 12 + ((Summa - month11) * Percent/100/12);
            Console.WriteLine("Результат = {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}", month1, month2, month3, month4, month5, month6, month7, month8, month9, month10, month11, month12);

            Console.ReadKey();

        }
    }
}
