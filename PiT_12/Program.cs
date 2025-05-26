using System;

namespace XmlDocumentationExample
{
    class Program
    {
        /// <summary>
        /// Главная точка входа в приложение.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatMessage("Привет, мир!", 3));
            Console.WriteLine(Sum(5, 10));
            Console.WriteLine(IsEven(7));
        }

        /// <summary>
        /// Повторяет указанное сообщение заданное количество раз.
        /// </summary>
        /// <param name="message">Сообщение для повтора.</param>
        /// <param name="count">Количество повторов.</param>
        /// <returns>Строка с сообщением, повторенным указанное количество раз.</returns>
        public static string RepeatMessage(string message, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += message + "\n";
            }
            return result;
        }

        /// <summary>
        /// Складывает два целых числа.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Сумма двух чисел.</returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Определяет, является ли число чётным.
        /// </summary>
        /// <param name="number">Число для проверки.</param>
        /// <returns>True, если число чётное; иначе false.</returns>
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
