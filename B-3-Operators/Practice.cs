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
        public static void B3_P1_9_NumbersAddition(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string S1 = Console.ReadLine();
            int a = Convert.ToInt32(S1);

            Console.WriteLine("Введите второе число");
            string S2 = Console.ReadLine();
            int b = Convert.ToInt32(S2);

            int c = a + b;
            Console.WriteLine("Результат с=", c);
            Console.ReadKey();
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string S1 = Console.ReadLine();
            int a = Convert.ToInt32(S1);

            Console.WriteLine("Введите второе число");
            string S2 = Console.ReadLine();
            int b = Convert.ToInt32(S2);

            int c = a + b;
            Console.WriteLine("Результат с=", c);
            Console.ReadKey();
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {

        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {

        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {

        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {

        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {

        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            
            Console.Write("Укажите радиус окружности: ");
            string S1 = Console.ReadLine();
            double R = Convert.ToDouble(S1);
            const double Pi = 3.14;
            double S = Pi * Math.Pow(R, 2);
            Console.WriteLine("{0:0.00} {1:0.00}", R, S);
           
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            Console.Write("Сумма кредита");
            string Sum = Console.ReadLine();
            double S = Convert.ToDouble(Sum);
            Console.Write("Проценты");
            string Per = Console.ReadLine();
            double P = Convert.ToDouble(Per);
            double month1, month2, month3, month4, month5, month6, month7, month8, month9, month10, month11, month12;
            month1 = S + (S * P);
            month2 = month1 + (month1 * P);
            month3 = month2 + (month2 * P);
            month4 = month3 + (month3 * P);
            month5 = month4 + (month4 * P);
            month6 = month5 + (month5 * P);
            month7 = month6 + (month6 * P);
            month8 = month7 + (month7 * P);
            month9 = month8 + (month8 * P);
            month10 = month9 + (month9 * P);
            month11 = month10 + (month10 * P);
            month12 = month11 + (month11 * P);
            Console.WriteLine("Результат =", month1, month2, month3, month4, month5, month6, month7, month8, month9, month10, month11, month12);
            Console.ReadKey();
        }
    }
}
