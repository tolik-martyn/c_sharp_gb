TaskSolution();

void TaskSolution()
{
    Console.WriteLine("Введите размер первоначального массива:");
    int size1 = Convert.ToInt32(Console.ReadLine());

    string[] text = new string[size1];

    FillArray1(text);
    Console.WriteLine($"Вывод заданного массива: [{string.Join(", ", text)}]");

    int limitation = 4;

    int size2 = Count(text);
    string[] threeSymbols = new string[size2];

    FillArray2(text, threeSymbols);
    Console.WriteLine($"Вывод итогового массива: [{string.Join(", ", threeSymbols)}]");



    void FillArray1(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите значение {i + 1}-го элемента массива:");
            array[i] = Console.ReadLine();
            if (array[i] == null) array[i] = String.Empty;
        }
    }

    int Count(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i].Length < limitation) count++;
        return count;
    }

    void FillArray2(string[] array1, string[] array2)
    {
        int j = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length < limitation)
            {
                array2[j] = array1[i];
                j++;
            }
        }
    }
}
