using System;

class Menu
{
    // Делегат для действий меню
    public delegate void MenuAction();

    // Метод для "Новая игра"
    public static void NewGame()
    {
        Console.WriteLine("Старт новой игры...");
    }

    // Метод для "Загрузка игры"
    public static void LoadGame()
    {
        Console.WriteLine("Загрузка игры...");
    }

    // Метод для "Правила"
    public static void Rules()
    {
        Console.WriteLine("Правила...");
    }

    // Метод для "Об авторе"
    public static void AboutAuthor()
    {
        Console.WriteLine("Об авторе...");
    }

    // Метод для "Выхода"
    public static void Exit()
    {
        Console.WriteLine("Выход...");
    }

    static void Main(string[] args)
    {
        // Массив методов для действий меню
        MenuAction[] menuActions = new MenuAction[]
        {
            Exit,
            NewGame,
            LoadGame,
            Rules,
            AboutAuthor
        };

        while (true)
        {
            // Показ меню
            Console.WriteLine("1 - Новая игра");
            Console.WriteLine("2 - Загрузить игру");
            Console.WriteLine("3 - Правила");
            Console.WriteLine("4 - Об авторе");
            Console.WriteLine("0 - Выход");
            Console.Write("Сделайте выбор: ");

            // Считывание ввода пользователем
            string? input = Console.ReadLine();

            try
            {
                int choice = Convert.ToInt32(input);
                if (choice >= 0 && choice <= 4)
                {
                    // Вызов соответствующего метода
                    menuActions[choice]();
                    if (choice == 0) // Выбор для Выхода
                    {
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Упс... Что-то пошло не так. Попробуйте еще раз.");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Введите число.");
            }

            Console.WriteLine();
        }
    }
}

