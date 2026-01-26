using System;

namespace Romchik
{
    class Program
    {
        private static void Main(string[] args)
        {
            string password = "3008"; // Переменная в которой хранится пароль

            Console.Write("Введите пароль: "); // Запрашиваем ввод у пользователя
            string userInputPassword = Console.ReadLine(); // Вводим пароль в переменную пользователь вводит пароль

            if (userInputPassword != password) // Условие проверяем если не совпадают пароли то тогда пишем в консоль
            {
                Console.WriteLine("\n\tПароль был не верно подобран"); // Ага
                Console.WriteLine("\n\tПопробуйте перезапустить программу..."); // Мг
            }

            else // Ну понятно сюда переходим если всё Good
            {
                Console.WriteLine("\n\tДобро пожаловать в систему..."); // Ну и выввод само сабой
            }
        }
    }
}