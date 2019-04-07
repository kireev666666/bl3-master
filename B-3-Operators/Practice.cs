using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            Console.WriteLine("Введите первое число");
            string S1 = Console.ReadLine();
            int a = Convert.ToInt32(S1);

            Console.WriteLine("Введите второе число");
            string S2 = Console.ReadLine();
            int b = Convert.ToInt32(S2);

            int c = a + b;
            Console.WriteLine("Результат с={0}", c);
            Console.ReadKey();
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите результат сложения");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == a + b)
                Console.WriteLine("True");
            else Console.WriteLine("False");
            Console.ReadKey();
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите результат сложения");
            int c = Convert.ToInt32(Console.ReadLine());
            bool y = (c > a + b || c < a + b);
            int g = c - (a + b);
            int h = a + b;
            c = y ? c - (a + b) : a + b;
            if (y == true & g > 0)
                Console.WriteLine("False, less");
            else if (y == true & g < 0)
                Console.WriteLine("False, more");
            else
                Console.WriteLine("True, {0}", h);

            Console.ReadKey();
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите результат сложения");
            int c = Convert.ToInt32(Console.ReadLine());
            bool y = (c > a + b || c < a + b);
            int g = c - (a + b);
            int h = a + b;
            c = y ? c - (a + b) : a + b;
            if (c == h)
                Console.WriteLine("True, {0}", h);
            else if (c != h & g < 0)
                Console.WriteLine("False, more");
            else if (c != h & g > 0)
                Console.WriteLine("False, less");

            Console.ReadKey();
        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите результат сложения");
            int c = Convert.ToInt32(Console.ReadLine());
            bool y = (c > a + b || c < a + b);
            int g = c - (a + b);
            int h = a + b;
            c = y ? c - (a + b) : a + b;
            if (c == h)
                Console.WriteLine("True, {0}", h);
            if (c != h & g < 0)
                Console.WriteLine("False, more");
            if (c != h & g > 0)
                Console.WriteLine("False, less");
            if (c != h)
                Console.WriteLine("Введите результат еще раз");
            int d = Convert.ToInt32(Console.ReadLine());
            if (h == d)
                Console.WriteLine("True, {0}", h);
            if (h != d)
                Console.WriteLine("Введите результат еще раз");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();

        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите четвертое число");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите пятое число");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите результат сложения");
            int c = Convert.ToInt32(Console.ReadLine());
            bool y = (c > a + b + q + r + l || c < a + b + q + r + l);
            int g = c - (a + b + q + r + l);
            int h = a + b + q + r + l;
            c = y ? c - (a + b + q + r + l) : a + b + q + r + l;
            if (c == h)
                Console.WriteLine("True, {0}", h);
            if (c != h & g < 0)
                Console.WriteLine("False, more");
            if (c != h & g > 0)
                Console.WriteLine("False, less");
            if (c != h)
                Console.WriteLine("Введите результат еще раз");
            int d = Convert.ToInt32(Console.ReadLine());
            if (h == d)
                Console.WriteLine("True, {0}", h);
            if (h != d)
                Console.WriteLine("Введите результат еще раз");
            int j = Convert.ToInt32(Console.ReadLine());
            
            Console.ReadKey();
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите четвертое число");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите пятое число");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите результат сложения");
            int c = Convert.ToInt32(Console.ReadLine());
            bool y = (c > a + b + q + r + l || c < a + b + q + r + l);
            int g = c - (a + b + q + r + l);
            int h = a + b + q + r + l;
            c = y ? c - (a + b + q + r + l) : a + b + q + r + l;
            if (c == h)
                Console.WriteLine("True, {0}", h);
            if (c != h & g < 0)
                Console.WriteLine("False, more");
            if (c != h & g > 0)
                Console.WriteLine("False, less");
            if (c != h)
                Console.WriteLine("Введите результат еще раз");
            int d = Convert.ToInt32(Console.ReadLine());
            if (h == d)
                Console.WriteLine("True, {0}", h);
            if (h != d)
                Console.WriteLine("Введите результат еще раз");
            int j = Convert.ToInt32(Console.ReadLine());
            if (h == j)
                Console.WriteLine("Задача решена правильно, {0}", h);
            else Console.WriteLine("Задача решена неправильно");
            Console.ReadKey();
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {

            Console.WriteLine("Укажите радиус круга: ");
            double R = Convert.ToDouble(Console.ReadLine());
            const double Pi = 3.14;
            //Площадь круга
            double S = Pi * Math.Pow(R, 2);
            Console.WriteLine("Площадь = {0}", S);

            Console.ReadKey();

        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            Console.WriteLine("Сумма кредита");
            double Summa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Проценты");
            double Percent = Convert.ToDouble(Console.ReadLine());
            double month1, month2, month3, month4, month5, month6, month7, month8, month9, month10, month11, month12;
            month1 = Summa / 12 + (Summa * Percent / 100 / 12);
            month2 = Summa / 12 + ((Summa - month1) * Percent / 100 / 12);
            month3 = Summa / 12 + ((Summa - month2) * Percent / 100 / 12);
            month4 = Summa / 12 + ((Summa - month3) * Percent / 100 / 12);
            month5 = Summa / 12 + ((Summa - month4) * Percent / 100 / 12);
            month6 = Summa / 12 + ((Summa - month5) * Percent / 100 / 12);
            month7 = Summa / 12 + ((Summa - month6) * Percent / 100 / 12);
            month8 = Summa / 12 + ((Summa - month7) * Percent / 100 / 12);
            month9 = Summa / 12 + ((Summa - month8) * Percent / 100 / 12);
            month10 = Summa / 12 + ((Summa - month9) * Percent / 100 / 12);
            month11 = Summa / 12 + ((Summa - month10) * Percent / 100 / 12);
            month12 = Summa / 12 + ((Summa - month11) * Percent / 100 / 12);
            Console.WriteLine("Результат = {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}", month1, month2, month3, month4, month5, month6, month7, month8, month9, month10, month11, month12);

            Console.ReadKey();
        }
    }
}
