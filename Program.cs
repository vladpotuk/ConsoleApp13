using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть перше число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        
        if (num1 > num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        Console.WriteLine($"Парні числа у діапазоні від {num1} до {num2}:");
        
        PrintEvenNumbers(num1, num2);
    }

    
    static void PrintEvenNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

