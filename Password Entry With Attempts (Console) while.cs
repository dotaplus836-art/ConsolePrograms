using System;

namespace Zed
{
    class Program
    {
        private const string Password = "777";
        private const int NumberAttempts = 3;
        private static void Main(string[] args)
        {
            int attempt = 1;
            bool isAuthorized = false;

            Console.WriteLine("Добро пожаловать в аккаунт");

            while (attempt <= NumberAttempts)
            {
                Console.Write("\nВведите пароль: ");
                string userInputPassword = Console.ReadLine();

                if (string.IsNullOrEmpty(userInputPassword))
                {
                    Console.WriteLine("Ошибка ввода. Попытка засчитана.");
                }

                else if (userInputPassword == Password)
                {
                    isAuthorized = true;
                    Console.WriteLine("\nВы успешно вошли в аккаунт!");
                    break;
                }

                else
                {
                    Console.WriteLine($"Неверный пароль. Осталось: {NumberAttempts - attempt} попыток");
                }

                attempt++;
            }

            if (!isAuthorized)
            {
                Console.WriteLine("\nВсе попытки закончены. Доступ заблокирован");
            }
        }
    }
}