using System;

namespace Zed
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal initialmount = ReadDecimal("Введите сумму вклада: ");
            int years = ReadInt("Введите срок вклада: ");
            decimal annualRate = ReadDecimal("Введите процент вклада: ");

            CalculateDeposid(initialmount, years, annualRate);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        private static void CalculateDeposid(decimal amount, int years, decimal annualRate)
        {
            for (int i = 1; i <= years; i++)
            {
                amount += amount * annualRate / 100;

                Console.WriteLine($"\nГод - {i} Счет - {amount:F2}");
            }
        }

        private static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (decimal.TryParse(Console.ReadLine(), out decimal value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Ощибка ввода. Введите положительное число\n");
            }
        }

        private static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Ошибка ввода. Введите положительное число\n");
            }
        }
    }
}