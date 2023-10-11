using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06HM
{
    public static class Program
    {
            static void Main(string[] args)
            {
                int attempts = 3;
                string correctPassword = "1234";

                Console.WriteLine("Введите пароль кредитной карты:");

                for (int i = 0; i < attempts; i++)
                {
                    string inputPassword = Console.ReadLine();
                    if (inputPassword == correctPassword)
                    {
                        ShowMenu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Неверный пароль. Осталось попыток: {attempts - i - 1}");
                    }
                }

                Console.WriteLine("Исчерпаны все попытки. Приложение завершено.");
            }

            static void ShowMenu()
            {
                while (true)
                {
                    Console.WriteLine("Меню:");
                    Console.WriteLine("a. Вывести баланс");
                    Console.WriteLine("b. Пополнить счет");
                    Console.WriteLine("c. Снять деньги");
                    Console.WriteLine("d. Выход");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "a":
                            // Реализация вывода баланса
                            break;
                        case "b":
                            // Реализация пополнения счета
                            break;
                        case "c":
                            // Реализация снятия денег
                            break;
                        case "d":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте ещё раз.");
                            break;
                    }
                }
            }
        
    }
}
