Console.Clear();

int ReadIntFromConsole(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountNumbers(int num)
{
    int count = 0;
    int currentNum = num;

    while (currentNum > 0)
    {
        count++;
        currentNum /= 10;
    }
    return count;
}

int GetFactorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}

void FillIntArray(int[] arr, int minVal = -99, int maxVal = 100)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal);
    }
}

void PrintIntArray(int[] arr)
{
    Console.Write($"Вывод массива: [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]");
}

// Task02();
// 2)Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

void Task02()
{
    int number = ReadIntFromConsole("Введите число: ");
    int count = GetCountNumbers(number);
    Console.WriteLine($"Количество цифр в числе {number} -> {count}");
}

// Task03();
// 3)Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120

void Task03()
{
    int number = ReadIntFromConsole("Введите число: ");
    int factorial = GetFactorial(number);
    Console.WriteLine($"Факториал числа {number} -> {factorial}");
}

// Task04();
// 4)Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Task04()
{
    int size = ReadIntFromConsole("Введите размер массива: ");
    int[] array = new int[size];

    FillIntArray(array, 0, 2);
    PrintIntArray(array);
}


