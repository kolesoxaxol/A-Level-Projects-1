using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using GameClass.Players;
using GameClass;

namespace GameProgram
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            int bucketWeight;
            string bucketWeightStr;
            int playerCounter = 0;

            Random rnd = new Random();

            do
            {
                Console.Write("Введите вес корзины от 40 до 140 кг.: ");
                bucketWeightStr = Console.ReadLine().Trim();
            } while (!int.TryParse(bucketWeightStr, out bucketWeight));

            if (bucketWeight > 140 || bucketWeight < 40)
            {
                Console.WriteLine("Вы ввели недопустимый вес корзины.");
                bucketWeight = rnd.Next(40, 140);
                Console.WriteLine($"Вес корзины установлен случайно: {bucketWeight}");
            }

            Game.SetBucketWeight(bucketWeight);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Создание игроков...");
            Console.WriteLine("В игре могут участвовать от 2 до 8 игроков");

            bool flag = true;

            do
            {
                Console.Write("Введите имя игрока: ");
                string playerName = Console.ReadLine().Trim();

                Console.WriteLine("Выберите роль игрока");
                Console.WriteLine("Введите - \"Обычный\", чтобы добавить обычного игрока.");
                Console.WriteLine("Введите - \"Игрок-блокнот\", чтобы добавить игрока с блокнотом.");
                Console.WriteLine("Введите - \"Убер-игрок\", чтобы добавить убер игрока.");
                Console.WriteLine("Введите - \"Читер\", чтобы добавить игрока читера.");
                Console.WriteLine("Введите - \"Убер-читер\", чтобы добавить игрока убер-читера.");
                Console.Write("Роль: ");

                string playerType = Console.ReadLine().Trim();

                switch (playerType)
                {
                    case "Обычный":
                        break;

                    case "Игрок-блокнот":
                        break;

                    case "Убер-игрок":
                        break;

                    case "Читер":
                        break;

                    case "Убер-читер":
                        break;

                    default:
                        Console.WriteLine("Вы указали роль не корректно.");
                        continue;
                }


                Player player = new Player(playerName, playerType);
                Game.AddPlayer(player);
                Console.WriteLine($"Игрок: {player.Name}, Роль: {player.Type} добавлен в игру.");

                playerCounter++;

                if (playerCounter >= 2)
                {
                    ConsoleKeyInfo pressedKey;
                    Console.WriteLine("Чтобы завершить добавление игроков, нажмите \"q\" или любую клавишу, чтобы продолжить добавление.");
                    pressedKey = Console.ReadKey(true);

                    switch (pressedKey.Key.ToString())
                    {
                        case "Q":
                            flag = false;
                        break;

                        default:
                            continue;
                    }
                }

            } while (flag);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"В игру добавлено: {playerCounter} игроков.");
            string startGameStr;
            do
            {
                Console.Write($"Введите \"Играть\" чтобы начать игру: ");
                startGameStr = Console.ReadLine();

            } while (startGameStr != "Играть");


            var winner = Game.Start();

            Console.WriteLine(new string('-', 50));

            if (winner is null)
            {
                Console.WriteLine($"Победителя нет.");
            }
            else
            {
                Console.WriteLine($"Победитель: {winner.Name}, Роль: {winner.Type}");
            }

            Console.ReadKey();

        }
    }
}
