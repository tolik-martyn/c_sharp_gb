//Это библитоека методов (чтобы в дальнейшем обращаться к методам). Актуально, когда рабочий и текущий файл находятся в одной рабочей папке (чтобы библиотека была не на стороннем сервисе). 

// К библиотеке подключаемся через "using <namespace>". Делаем это из файла, в который нужно передать метод из текущей библиотеки/<namespace>. Пример заполнения: <using LibraryHelp;>.
// Но если мы напрямую обращаемся к методу через "namespace.class.<название метода, который вызываем>", то в рабочем файле мы не указываем "using <namespace>" (<using LibraryHelp;>).
// Если бы <namespace> при вызове метода не указывали, то тогда обязательно для подключения к библиотеке нужно указывать "using <namespace>" (<using LibraryHelp;>).

// Для обращения к библиотеке с вызовом метода нужно выполнить: <LibraryHelp.Methods.Help> ("namespace.class.<название метода, который вызываем>").

// В текущем файле перед  названием метода обязательно указываем <public static> (пример: <public static void Help()>). 
// <public> - по умолчанию всё считается приватным, если не указано другое. Поэтому мы делает метод публичным через <public>.
// <static> - делает метод постоянным. Теперь этот метод существует не зависимо от экземпляров объекта (существует в единственном виде для всех, и все другие о нем знают).

namespace LibraryHelp
{
    class Methods
    {
        public static void FillArray(int[] numbers, int minValue = 0, int maxValue = 100) // метод для заполнения массива целыми числами. =>
        // => <minValue = 0, int maxValue = 100> - так мы указываем значения по умолчанию от <0> до <100>. =>
        // => Если при вызове метода <FillArray> не указываать <minValue>, <maxValue>, то ошибки не будет (так как подставятся значения по умолчанию). 
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
        }

        //----------------------------------------------------------------------------------------------------

        public static void FillArrayDouble(double[] numbers, int minValue = 0, int maxValue = 100, int roundNum = 2) 
        // метод для заполнения массива вещественными (дробными) числами. <roundNum> - разряд, до которого округляем ("1" - до десятых, "2" - до сотых и т.д.). 
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Round((random.Next(minValue, maxValue) * random.NextDouble()), roundNum);
            }
        }

        //----------------------------------------------------------------------------------------------------

        public static void PrintArray(int[] numbers) // метод для печати массива, который заполнен целыми числами. 
        {
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }

        //----------------------------------------------------------------------------------------------------

        public static void PrintArrayDouble(double[] numbers) // метод для печати массива, который заполнен вещественными (дробными) числами.
        {
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            Console.WriteLine();
        }

        //----------------------------------------------------------------------------------------------------

    }
}
