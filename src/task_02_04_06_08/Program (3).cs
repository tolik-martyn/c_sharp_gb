// Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

int N = 1;

Console.WriteLine("Введите целое число от 1 и более:");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1)
{
    Console.WriteLine("Введите целое число от 1 и более:");
    number = Convert.ToInt32(Console.ReadLine());
}

while (number == 1)
{
    Console.WriteLine("В этом диапазоне нет целых четных чисел. Попробуйте ввести другое целое число:");
    number = Convert.ToInt32(Console.ReadLine());
}

while (N <= number)
{
   if (N % 2 == 0)
   {
    Console.Write(N + ", ");
   }
   N = N + 1;
}
Console.Write("\b\b");
Console.WriteLine();