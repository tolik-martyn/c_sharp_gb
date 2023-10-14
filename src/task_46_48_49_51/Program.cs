Console.Clear();

// Task46();
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами. m = 3, n = 4.
// 1   4   8   19
// 5   -2  33  -2
// 77  3   8   1

void Task46()
{
    int[,] matrix = CreateAndFillIntMatrix();
    PrintIntMatrix(matrix);
}


// Task48();
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
// Выведите полученный массив на экран. m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void Task48()
{
    int rows = ReadIntFromConsole("Введите количество строк: ");
    int columns = ReadIntFromConsole("Введите количество столбцов: ");

    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = i + j;
        }
    }

    PrintIntMatrix(matrix);
}


// Task49();
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void Task49()
{
    int[,] matrix = CreateAndFillIntMatrix(1, 9);
    PrintIntMatrix(matrix);

    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i += 2)
    {
        for (int j = 0; j < columns; j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }

    PrintIntMatrix(matrix);
}


// Task51();
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

void Task51()
{
    int[,] matrix = CreateAndFillIntMatrix(1, 9);
    PrintIntMatrix(matrix);

    int sum = 0;
    int lenght = matrix.GetLength(0) > matrix.GetLength(1) ? matrix.GetLength(1) : matrix.GetLength(0);

    for (int i = 0; i < lenght; i++)
    {
        sum += matrix[i, i];
    }
    Console.WriteLine($"Сумма элементов по диагонали -> {sum}");
}


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
