using System;

namespace Zed
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int playerHealth = ReadInt("Введите здоровье Игроку: ");
            int enemyHealth = ReadInt("Введите здоровье Врагу: ");

            int playerDamage = ReadInt("Введите урон Игроку: ");
            int enemyDamage = ReadInt("Введите урон Врагу: ");

            Fight(playerHealth, enemyHealth, playerDamage, enemyDamage);
        }

        private static void Fight(int playerHealth, int enemyHealth, int playerDamage, int enemyDamage)
        {
            int round = 1;

            Console.Clear();

            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine($"Раунд: {round++}");
                Console.ReadKey();

                enemyHealth = Math.Max(0, enemyHealth - playerDamage);
                Console.WriteLine($"Игрок наносит: {playerDamage} урона. Здоровье Врага: {enemyHealth}");

                if (enemyHealth <= 0) break;

                playerHealth = Math.Max(0, playerHealth - enemyDamage);
                Console.WriteLine($"Враг наносит: {enemyDamage} урона. Здоровье Игрока: {playerHealth}\n");
            }
            
            if (playerHealth <= 0)
                Console.WriteLine("\nВраг победил");

            else if(enemyHealth <= 0)
                Console.WriteLine("\nИгрок победил");
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

                Console.WriteLine("Ошибка ввода. Число должно быть положительным");
            }
        }
    }
}