// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите количество строк: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] str = new string[n];

        void PrintStartArray(string[] str)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите строку №{0}: ", i + 1);
                str[i] = Console.ReadLine()!;
            }
            Console.WriteLine("Начальный массив строк:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(str[i] + " ");
            }
        }
        PrintStartArray(str);

        Console.WriteLine();

        Console.WriteLine("Конечный массив строк:");
        void GetStringArray(string[] str)
        {
            string[] newStr = new string[str.Length];
            string temp1 = "abc";
            for (int i = 0; i < str.Length; i++)
            {
                string temp2 = str[i];
                if (temp2.Length <= temp1.Length)
                {
                    newStr[i] = str[i];
                    Console.Write(newStr[i] + " ");
                }
            }
            Console.Write(" ");
        }
        GetStringArray(str);
    }
}