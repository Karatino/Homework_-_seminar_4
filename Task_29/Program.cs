/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Элементы массива вводятся пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


Console.Write("Введите количество элементов масива: ");

int elementsCount = int.Parse(Console.ReadLine());

int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива по индексом {i}: ");
        myArray[i] = int.Parse(Console.ReadLine());
    }



System.Console.WriteLine("Вывод масива: ");

for (int i = 0; i < myArray.Length; i++)
    {
            Console.WriteLine(myArray[i]);
    }

Console.ReadLine();
