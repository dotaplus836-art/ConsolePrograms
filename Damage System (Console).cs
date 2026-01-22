using System;

namespace FirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Начало программы

            string name;
            float health; // Так тут у нас Здоровье
            int armor; // Тут Броня
            int damade; // Тут Урон 
            int precentConverter = 100;

            Console.Write("Введите имя игроку: "); // Просим у пользователя вписать имя игрока 
            name = Console.ReadLine(); // Записум ответ пользователя в переменную имя

            Console.Write("Введите здоровье игроку: "); // Просим у пользователя вписать здоровья игрока
            health = Convert.ToInt32(Console.ReadLine()); // Записуем ответ пользователя в переменную здоровья

            Console.Write("Введите броню игроку: "); //Просим у пользователя вписать броню игрока
            armor = Convert.ToInt32(Console.ReadLine()); // Записуем ответ пользователя в переменную брони 

            Console.Write("Введите урон наносимый игроку: "); // Просим у пользователя вписать урон наносимый игроку
            damade = Convert.ToInt32(Console.ReadLine()); // Записуем ответ пользователя в переменную урон

            health -= Convert.ToSingle(damade) / precentConverter * armor;
            // В общем и целом здесь происходит что мы берем и уменьшаем здоровье игрока от урона
            // После умножаем его на броню ну и делим наш precentConverter что бы преоброзовать в проценты

            Console.WriteLine($"\nВы нанесли: {damade} урона.У игрока осталось: {health} здоровья");
            // Считаем вычисление и выводим полученный урон и оставшееся здоровье

            // Конец программы












        }
    }
}