/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт
номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
int M = InputNumber("Введите количество строк в массиве M: ");
int N = InputNumber("Введите количество столбцов в массиве N: ");
int[,] Matrix = new int[M, N];
PrintArray(FillArray(Matrix));
MinSumStringArray(Matrix);

void MinSumStringArray(int[,] matrix)
{
    int minSum = 0;
    int index=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {Sum}");
        if (i == 0)
        {
            minSum = Sum;
        }
        else if (Sum < minSum)
        {
            minSum = Sum;
            index=i+1;
        }
    }
    System.Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index}. ");
}

int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 99);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}  \t ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}