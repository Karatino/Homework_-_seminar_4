/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Решить задачу с использованием методов.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Double GetDegree(double a, Double b)
{

    double degree = Math.Pow(a, b);

    Console.WriteLine($"Готово! {a} в степени {b} равно {degree}!");

    return degree ;
}

Console.Write("Пожалуйста, введите число, которое вы хотите возвести в степень: ");
int a = int.Parse(Console.ReadLine());

Console.Write($"Спасибо, теперь введите степень, в которую хотите возвести число {a}: ");
int b = int.Parse(Console.ReadLine());

Double DegreeNumber = GetDegree(a, b);
Console.WriteLine(DegreeNumber);

