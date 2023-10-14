Console.Clear();

//---------------------------------

Ex25();
// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Ex25()
{
    Console.WriteLine("Введите натуральное число A:");
    int numberA = Convert.ToInt32(Console.ReadLine());
    while (numberA < 1)
    {
        Console.WriteLine("Неверный ввод.Введите натуральное число A:");
        numberA = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Введите натуральное число B:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    while (numberB < 1)
    {
        Console.WriteLine("Неверный ввод.Введите натуральное число B:");
        numberB = Convert.ToInt32(Console.ReadLine());
    }

    int result = numberA;

    for (int i = 1; i < numberB; i++)
    {
        result *= numberA;
    }
    Console.WriteLine($"{numberA} в степени {numberB} = {result}");
    Console.WriteLine("");
}

//---------------------------------

Ex27();
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Ex27()
{
    Console.WriteLine("Введите натуральное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    while (number < 1)
    {
        Console.WriteLine("Неверный ввод.Введите натуральное число:");
        number = Convert.ToInt32(Console.ReadLine());
    }

    int current_number1 = number;
    int count = 0;

    while (current_number1 > 0)
    {
        current_number1 = current_number1 / 10;
        count += 1;
    }

    Console.WriteLine($"Количество цифр в числе {number} равно: {count}");

    double sum = 0;
    double current_number2 = number;
    int current_count = count - 1;

    for (int i = 0; i < count; i++)
    {

        double stepen = Math.Pow(10, current_count); // путем деления или умножения на эту переменную мы получим нужный нам разряд числа. 

        double digit = Math.Floor(current_number2 / stepen); // здесь находим первую искомую цифру (начиная слева) и затем последующие.

        sum = sum + digit; // здесь подсчитываем итоговую сумму цифр нашего числа. 

        current_number2 = current_number2 - digit * stepen; // здесь убираем самый высокий разряд (чтобы на следующем цикле работать со следующим разрядом).

        current_count--; // уменьшаем на 1, чтобы на следущем цикле сделать степень на 1 меньше.
    }
    Console.WriteLine($"Cумма цифр в числе {number} равна: {sum}");
    Console.WriteLine("");
}

//---------------------------------


Ex29();
// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]

void Ex29()
{
    int sizeArray = 8;
    int[] numbers = new int[sizeArray];

    FillArray(numbers);
    Console.Write("Массив до сортировки: ");
    PrintArray(numbers);
    SelectionSort(numbers);
    Console.Write("Массив после сортировки: ");
    PrintArray(numbers);

    void FillArray(int[] num1)
    {
        Random random = new Random();
        for (int i = 0; i < num1.Length; i++)
        {
            num1[i] = random.Next(-99, 100);
        }
    }

    void PrintArray(int[] num2)
    {
        for (int i = 0; i < num2.Length; i++)
        {
            Console.Write(num2[i] + " ");
        }
        Console.WriteLine();
    }

    void SelectionSort(int[] num3)
    {
        for (int i = 0; i < num3.Length - 1; i++) //<array.Length - 1> - здесь <-1>, потому что ниже в цикле <int j = i + 1> (это нужно, чтобы искусственно сократить длину массива).
        {
            int minPosition = i; // через переменную определяем позицию, с которой будем работать. Здесь позиция - это <i> (индекс).

            for (int j = i + 1; j < num3.Length; j++) // <int j = i+1> - чтобы начать с неотсортированной части (а отсортированную не трогать, поэтому <i+1>>).
            {
                if (Math.Abs(num3[j]) < Math.Abs(num3[minPosition])) // здесь ищем минимальный элемент по модулю. 
                {
                    minPosition = j;
                }
            }

            int temporary = num3[i]; // для запоминания той позиции, с которой мы работали (чтобы в дальнейшем поменять значение минимальной позиции с той позицией, которую мы нашли).
            num3[i] = num3[minPosition]; // для обмена двух переменных местами.
            num3[minPosition] = temporary; // для обмена двух переменных местами.
        }
    }
}

//---------------------------------
