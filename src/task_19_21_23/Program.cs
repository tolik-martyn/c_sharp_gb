Console.Clear();

Ex19();
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Ex21();
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Ex23();
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Ex19()
{
    Console.WriteLine("Введите целое пятизначное число:");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 10000 && number < 99999)
    {
        int tens_thousands = number / 10000;
        int thousands = number / 1000 % 10;
        int hundreds = number / 100 % 10;
        int tens = number / 10 % 10;
        int ones = number % 10;

        if (tens_thousands == ones && thousands == tens)
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }

        else
        {
            Console.WriteLine($"Число {number} НЕ является палиндромом");
        }
    }

    else
    {
        Console.WriteLine("Введен неверный номер");
    }
}

void Ex21()
{
    Console.WriteLine("Введите координаты точки A:");
    Console.Write("x1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y1: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z1: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"A: ({x1}, {y1}, {z1})");

    Console.WriteLine("Введите координаты точки B:");
    Console.Write("x2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"B: ({x2}, {y2}, {z2})");

    Console.WriteLine("Для поиска расстояния АВ (x1,y1,z1 и x2,y2,z2) нам понадобится расстояние АС (x1,y1,z1 и x2,y1,z2) и расстояние ВС (x2,y2,z2 и x2,y1,z2)");
    Console.WriteLine("Для поиска расстояния АС (x1,y1,z1 и x2,y1,z2) нам понадобится расстояние АD (x1,y1,z1 и x2,y1,z1) и расстояние CD (x2,y1,z2 и x2,y1,z1)");
    Console.WriteLine($"С: ({x2}, {y1}, {z2})");
    Console.WriteLine($"D: ({x2}, {y1}, {z1})");

    int AD = x2 - x1;
    int СD = z2 - z1;
    int BC = y2 - y1;

    Console.WriteLine("Расстояние между точками А и D = " + AD);
    Console.WriteLine("Расстояние между точками C и D = " + СD);
    Console.WriteLine("Расстояние между точками B и С = " + BC);

    double AC = Math.Sqrt(Math.Pow(AD, 2) + Math.Pow(СD, 2));
    Console.WriteLine("Расстояние между точками А и С = " + AC);

    double АВ = Math.Sqrt(Math.Pow(AC, 2) + Math.Pow(BC, 2));
    Console.WriteLine("Ответ: расстояние между точками А и В = " + АВ);
}

void Ex23()
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Число\tКуб");
    int count = 1;

    while (count <= number)
    {
        double cube = Math.Pow(count, 3);
        Console.WriteLine("{0}\t{1}\t", count, cube);
        count++;
    }
}
