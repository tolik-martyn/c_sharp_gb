Console.Clear();



Ex34();
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Ex34()
{
    int size = 10;
    int[] numbers = new int[size];

    LibraryHelp.Methods.FillArray(numbers, 100, 999);
    LibraryHelp.Methods.PrintArray(numbers);

    Console.WriteLine("Количество чётных чисел в массиве = " + GetQuantityEvenNum(numbers));

    int GetQuantityEvenNum(int[] num)
    {
        int quantity = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] % 2 == 0)
            {
                quantity++;
            }
        }
        return quantity;
    }

    Console.WriteLine("");
}



Ex36();
// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Ex36()
{
    int size = 10;
    int[] numbers = new int[size];

    LibraryHelp.Methods.FillArray(numbers, -99, 99);
    LibraryHelp.Methods.PrintArray(numbers);

    Console.WriteLine("Сумма элементов с нечётными индексами = " + GetSumOddIndex(numbers));

    int GetSumOddIndex(int[] num)
    {
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (i % 2 == 1)
            {
                sum += num[i];
            }
        }
        return sum;
    }

    Console.WriteLine("");
}




Ex38();
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 75,53

void Ex38()
{
    int size = 10;
    double[] numbers = new double[size];

    LibraryHelp.Methods.FillArrayDouble(numbers, -100, 100, 2);
    LibraryHelp.Methods.PrintArrayDouble(numbers);

    Console.WriteLine("Максимальный элемент массива = " + FindMaxNum(numbers));
    Console.WriteLine("Минимальный элемент массива = " + FindMinNum(numbers));

    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {FindMaxNum(numbers) - FindMinNum(numbers)}");

    double FindMaxNum(double[] numbers)
    {
        double maxNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        return maxNumber;
    }

    double FindMinNum(double[] numbers)
    {
        double minNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }
        return minNumber;
    }
}
