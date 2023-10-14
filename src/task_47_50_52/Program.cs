Console.Clear();



Ex47();
// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Ex47()
{
    Console.WriteLine($"Задача 47:");

    Random random = new Random();

    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);
    Console.WriteLine($"Размер массива: {rows} * {columns}");

    double[,] numbers = new double[rows, columns];

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Math.Round((random.Next(-99, 100) * random.NextDouble()), 1);
        }
    }

    Console.WriteLine("Вывод двумерного массива:");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



Ex50();
// Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Ex50()

{
    Console.WriteLine($"Задача 50:");

    int rows = 4;
    int columns = 5;

    int[,] numbers = new int[rows, columns];

    LibraryHelp.Methods.FillArray(numbers, -99, 99);

    Console.WriteLine("Введите индекс i:");
    int indexI = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите индекс j:");
    int indexJ = Convert.ToInt32(Console.ReadLine());

    LibraryHelp.Methods.PrintArray(numbers);

    if (indexI >= rows || indexJ >= columns)
    {
        Console.WriteLine($"Элемент с индексом ({indexI}, {indexJ}) не существует в текущем массиве");
    }
    else
    {
        Console.WriteLine($"Значение элемента с индексом ({indexI}, {indexJ}) равно: {numbers[indexI, indexJ]}");
    }
}



Ex52();
// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Ex52()
{
    Console.WriteLine($"\nЗадача 52:");

    Random random = new Random();

    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);
    Console.WriteLine($"Размер массива: {rows} * {columns}");

    int[,] numbers = new int[rows, columns];

    LibraryHelp.Methods.FillArray(numbers, 1, 9);
    LibraryHelp.Methods.PrintArray(numbers);

    Console.WriteLine("Среднее арифметическое элементов столбца");

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double count = 0;
        double sum = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sum += numbers[i, j];
            count++;
        }

        double average = sum / count;
        average = Math.Round(average, 2);
        Console.Write($"{average}\t");
    }
}
