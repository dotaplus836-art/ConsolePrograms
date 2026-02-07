using System;

namespace Romchik
{
    class Program
    {
        private const float RubToUsd = 0.013f; // Перевод рубли в доллары 
        private const float UsdToRub = 76f; // Перевод доллары в рубли

        private static float _rublesInWallet; //  Переменная баланс рублей
        private static float _dollarsInWallet; // Переменная баланс долларов
        private static float _exchangeCurrencyCount; // Текущая введённая сумма которую мы хотим обменять 

        private static ConsoleColor _defaultColor = Console.ForegroundColor; // Переменная для окраски консоли в выбранный цвет

        private static void Main(string[] args)
        {
            string desiredOperation = ""; // Переменная желаемая операция

            ChangeColorConsole(ConsoleColor.Green); // Окрашивании в желаемый цвет

            Console.WriteLine("\t\t\tДобро пожаловать в обменник валют! (RUB) (USD)"); // Приветствуем пользователя

            ResetColorConsole(); // Возвращение цвета консоли в дефолтный её цвет

            Console.Write("\nВведите ваш текущий баланс рублей: "); // Запрашиваем баланс рублей
            _rublesInWallet = Convert.ToSingle(Console.ReadLine()); // Вводим в переменную кошелек рублей

            Console.Write("Введите ваш текущий баланс долларов: "); // Запрашиваем баланс долларов
            _dollarsInWallet = Convert.ToSingle(Console.ReadLine()); // Вводим в переменную кошелек долларов

            InputUserOperation(desiredOperation, _exchangeCurrencyCount, _rublesInWallet, _dollarsInWallet); // Метод где происходит выбор операции
        }

        private static void InputUserOperation(string desiredOperation, float exchangeCurrencyCount, float rublesInWallet, float dollarsInWallet) // Выбор операции 
        {
            Console.Clear(); // Очистка консоли

            ChangeColorConsole(ConsoleColor.DarkGreen); // Окрашивание консоли в желаемый цвет 

            Console.WriteLine("\t\t\tВыберете операцию"); // Выбор операции
            Console.WriteLine($"\n\nНажмите (1) Перевести Rub в Usd\t|\t|Баланс Rub: {_rublesInWallet}R"); // 1 операция обмена рублей на доллары
            Console.WriteLine($"Нажмите (2) Перевести Usd в Rub\t|\t|Баланс Usd: {_dollarsInWallet}$"); // 2 операция обмена долларов на рубли

            ResetColorConsole(); // Смена на default цвет консоли

            Console.Write("\n\nОтвет: "); // Просим пользователя ввести операцию
            desiredOperation = Console.ReadLine(); // Выводим её в переменную с операциями

            switch (desiredOperation) // Условный оператор в качестве условия вставляем переменную с выбранной операцией 
            {
                case "1": // 1 операция
                    Operation("Сумма Рублей", "Сколько рублей вы хотите обменять", "USD", rublesInWallet, exchangeCurrencyCount, RubToUsd); // 1 случай на обмен рублей в доллары
                    break;

                case "2": // 2 операция
                    Operation("Сумма Доллары", "Сколько долларов вы хотите обменять", "RUB", dollarsInWallet, exchangeCurrencyCount, UsdToRub); // 2 случай на обмен долларов в рубли
                    break;

                default: // Ну это если пользователь указал что то бредовое в консоль
                    ChangeColorConsole(ConsoleColor.DarkRed); // Окрашивание в желаемый цвет 
                    Console.WriteLine("\n\t\t\tВы ввели неверную операцию\n\n\t\t\tПерезапустите программу\n..."); // Вывод при неверно выбранной операции 
                    ResetColorConsole(); // Возвращение цвета консоли в дефолтное её состояние 
                    break;
            }
        }

        private static void Operation(string amountMoney, string numberExchanges, string currency, float balance, float exchangeCurrencyCount, float currentCurrency) // Сама логика обмена денег
        {
            Console.Clear(); // Очистка консоли

            Console.WriteLine($"{amountMoney}: {balance}"); // Ввод
            Console.Write($"\n{numberExchanges}: "); // Ввод

            exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine()); // Записуем в нашу переменную в сумму которую хочет обменять пользователь 

            if (balance >= exchangeCurrencyCount) // Проверка что волюты которую мы хотим поменять больше равно указанной 
            {
                Console.Clear(); // Очистка консоли

                float converted = exchangeCurrencyCount * currentCurrency; // Переменная которая умножает текущую сумму на курс 

                balance -= exchangeCurrencyCount; // Вычитаем из баланса написанную сумму 
                balance += converted; // И плюсуем её с конвертированной суммой

                Console.WriteLine($"{currency} = {balance}"); // Вывод баланса
            }

            else // если пользователь указал сумму больше чем у него есть на самом деле
            {
                Console.WriteLine("\n\t\tУ вас нет такой суммы"); // Просим перезапустить консоль
                Console.WriteLine("\nПерезапустите программу....."); // Пока пока
            }
        }

        private static void ChangeColorConsole(ConsoleColor color) => Console.ForegroundColor = color; // Метод для окрашивания консоли

        private static void ResetColorConsole() => Console.ForegroundColor = _defaultColor; // Метод для возвращение дефолтного её цвета
    }
}