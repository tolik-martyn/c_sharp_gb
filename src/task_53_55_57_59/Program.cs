Console.Clear();


// Task53();
// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void Task53()
{
    int[,] matrix = CreateAndFillIntMatrix(1, 9);
    PrintIntMatrix(matrix);
    ChangeFirstAndLastRowsByMatrix(matrix);
    PrintIntMatrix(matrix);
}


// Task55();
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void Task55()
{
    int[,] matrix = CreateAndFillIntMatrix(1, 9);

    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        PrintIntMatrix(matrix);
        ChangeRowsForColumnsByMatrix(matrix);
        PrintIntMatrix(matrix);
    }
    else Console.WriteLine("Заменить строки на столбы невозможно, так как их количество должно совпадать");
}


Task57();
// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

void Task57()
{
    int[,] matrix = CreateAndFillIntMatrix(0, 9);
    PrintIntMatrix(matrix);

    GetFrequencyDictionaryFromZeroToNine(matrix);
}


Task59();
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


int ReadIntFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateAndFillIntMatrix(int minVal = -99, int maxVal = 99)
{
    maxVal++;
    Random rand = new Random();

    int rows = ReadIntFromConsole("Введите количество строк: ");
    int columns = ReadIntFromConsole("Введите количество столбцов: ");

    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minVal, maxVal);
        }
    }
    return matrix;
}

void PrintIntMatrix(int[,] matrix)
{
    Console.WriteLine("Вывод двумерного массива:");
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ChangeFirstAndLastRowsByMatrix(int[,] matrix)
{
    int columns = matrix.GetLength(1);
    int first = 0;
    int last = matrix.GetLength(0) - 1;

    for (int j = 0; j < columns; j++)
    {
        (matrix[first, j], matrix[last, j]) = (matrix[last, j], matrix[first, j]);
    }
}

void ChangeRowsForColumnsByMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
        }
    }
}

void GetFrequencyDictionaryFromZeroToNine(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    int size = 10;
    int[] array = new int[size];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[matrix[i, j]]++;
        }
    }

    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) Console.WriteLine($"Цифра {i} встречается {array[i]} раз(а)");
    }
}
