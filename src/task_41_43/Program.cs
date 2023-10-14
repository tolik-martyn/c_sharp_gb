Console.Clear();



// Ex41();
// Ex41_1();
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

void Ex41()
{
    int size = 5;
    int[] numbers = new int[size];

    FillArray(numbers);

    void FillArray(int[] num1)
    {
        for (int i = 0; i < num1.Length; i++)
        {
            Console.WriteLine($"Введите {i + 1}-ый элемент массива:");
            num1[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    int GetQuantityPositiveNum(int[] num)
    {
        int quantity = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > 0)
            {
                quantity++;
            }
        }
        return quantity;
    }

    LibraryHelp.Methods.PrintArray(numbers);

    Console.WriteLine("Количество чисел больше 0: " + GetQuantityPositiveNum(numbers) + "\n");
}

void Ex41_1()
{
    Console.WriteLine("Чтобы прекратить набор чисел, введите: -55555");

    СountPositiv();

    void СountPositiv(int countPositiv = 0)
    {
        int stop = -55555;

        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == stop)
        {
            Console.WriteLine($"Ввод чисел остановлен");
            return;
        }

        else if (number > 0)
        {
            Console.Clear();
            Console.WriteLine("Чтобы остановить набор чисел, введите: -55555");
            countPositiv++;
            Console.WriteLine($"Количество чисел больше 0: {countPositiv}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Чтобы остановить набор чисел, введите: -55555");
            Console.WriteLine($"Количество чисел больше 0: {countPositiv}");
        }

        СountPositiv(countPositiv);
    }
}



// Ex43();
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Ex43()
{
    Console.WriteLine("Введите k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите k2");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b2");
    double b2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;

    Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y1})");
}
