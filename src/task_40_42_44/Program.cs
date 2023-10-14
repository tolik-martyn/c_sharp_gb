Console.Clear();


// Ex40();
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

void Ex40()
{
    int number1 = ReadIntFromConsole("Введите первое число: ");
    int number2 = ReadIntFromConsole("Введите второе число: ");
    int number3 = ReadIntFromConsole("Введите третье число: ");

    Сheck3Angels(number1, number2, number3);
}


// Ex42();
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void Ex42()
{
    int number = ReadIntFromConsole("Введите десятичное число: ");

    DecToBin(number);

    string result = Convert.ToString(number, 2);
    Console.WriteLine($"Десятичное число {number} в двоичной системе -> {result}");

    string res = String.Empty;
    int currentNumber = number;
    while (currentNumber > 0)
    {
        res = (currentNumber % 2).ToString() + res; // в методе <DecToBin> операция работает без конвертации через <ToString()>.
        currentNumber /= 2;
    }
    Console.WriteLine($"Десятичное число {number} в двоичной системе -> {res}");
}


// Ex44();
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Ex44()
{
    int number = ReadIntFromConsole("Введите число N: ");

    GetFibonacci(number);
}


// Ex42_01();
// Доп. решение через динамический массив.

void Ex42_01()

{
    int number = ReadIntFromConsole("Введите десятичное число: ");

    List<int> ConvertDecimalToDouble(int num)
    {
        List<int> answer = new List<int>(); // <List> - динамический массив, у него нет размера. Поэтому при его создании не задают размер. 
        for (; num > 0; num /= 2) // в цикле <for> некоторые условия можно опускать и не указывать (в нашем случае мы не добавили <int i>). 
        {
            answer.Add(num % 2); // здесь заполняем динамический массив. 
        }
        answer.Reverse(); // здесь разворачиваем динамический массив.
        return answer;
    }

    Console.WriteLine(String.Join("", ConvertDecimalToDouble(number)));
}


int ReadIntFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateAndFillIntArray(int minVal = -99, int maxVal = 99)
{
    maxVal++;
    int size = ReadIntFromConsole("Введите размер массива: ");
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal);
    }
    return arr;
}

string PrintIntArray(int[] arr)
{
    return String.Join(", ", arr);
}

void Сheck3Angels(int num1, int num2, int num3)
{
    if (num1 + num2 > num3
        && num2 + num3 > num1
        && num1 + num3 > num2)
        Console.WriteLine("Такой треугольник может существовать");
    else Console.WriteLine("Такой треугольник не может существовать");
}

void DecToBin(int num)
{
    int curNum = num;
    string remain = String.Empty;

    while (curNum > 0)
    {
        remain = curNum % 2 + remain;
        curNum /= 2;
    }

    Console.WriteLine($"Десятичное число {num} в двоичной системе -> {remain}");
}

void GetFibonacci(int num)
{
    int x1 = 0;
    int x2 = 1;
    Console.Write($"Если N = {num} -> {x1} {x2} ");
    for (int i = 2; i < num; i++)
    {
        (x1, x2) = (x2, x1 + x2);
        Console.Write($"{x2} ");
    }
}
