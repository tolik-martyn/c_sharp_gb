Console.Clear();

Console.WriteLine("Задача 10:");
Ex10();
Console.WriteLine();
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Задача 13:");
Ex13();
Console.WriteLine();
// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267432979 -> 6

Console.WriteLine("Задача 15:");
Ex15();
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Ex10()
{
    Console.WriteLine("Введите трёхзначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);

    while (number < 100 || number > 999)
    {
        Console.WriteLine("Неверный ввод. Введите трёхзначное число:");
        number = Convert.ToInt32(Console.ReadLine());
        number = Math.Abs(number);
    }

    Console.WriteLine($"Вторая цифра: {number / 10 % 10}");
}

void Ex13()
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);

    if (number > 99)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine($"Третья цифра: {number % 10}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

void Ex15()
{
    Console.WriteLine("Введите цифру от 1 до 7:");
    int day = Convert.ToInt32(Console.ReadLine());

    while (day < 1 || day > 7)
    {
        Console.WriteLine("Неверный ввод. Введите цифру от 1 до 7:");
        day = Convert.ToInt32(Console.ReadLine());
    }

    if (day == 1)
    {
        Console.WriteLine("Понедельник - будний день");
    }

    else if (day == 2)
    {
        Console.WriteLine("Вторник - будний день");
    }

    else if (day == 3)
    {
        Console.WriteLine("Среда - будний день");
    }

    else if (day == 4)
    {
        Console.WriteLine("Четверг - будний день");
    }

    else if (day == 5)
    {
        Console.WriteLine("Пятница - будний день");
    }

    else if (day == 6)
    {
        Console.WriteLine("Суббота - выходной день");
    }

    else
    {
        Console.WriteLine("Воскресение - выходной день");
    }
}
