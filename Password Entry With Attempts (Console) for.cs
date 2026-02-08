using System;

namespace Zed
{
    class Program
    {
        private const int NumberAttempts = 3;
        private const string Password = "6996";

        private static void Main(string[] args)
        {
            bool isAuthorized = false;

            Console.WriteLine("Приветствую");
            Console.WriteLine("Войдите в аккаунт");

            for (int i = 1; i <= NumberAttempts; i++)
            {
                Console.Write("\nВведите пароль: ");
                string userInputPassword = Console.ReadLine();

                if (userInputPassword is null)
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }

                if (userInputPassword == Password)
                {
                    isAuthorized = true;
                    Console.WriteLine("\nВы успешно вошли в аккаунт");
                    break;
                }

                Console.WriteLine($"Неверный пароль. Осталось: {NumberAttempts - i} попыток");
            }

            if (!isAuthorized)
            {
                Console.WriteLine("\nПопытки закончились. Доступ запрещён");
            }
        }
    }
}