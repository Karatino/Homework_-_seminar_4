/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

static int SumNumbers(int value)
    {
        int result = 0;
        while (value > 0)
        {
            result += value % 10;
            value = value / 10;
        }
        return result;
        Console.WriteLine(result);
    }

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int result = SumNumbers(num);
Console.WriteLine(result);