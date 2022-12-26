/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/

Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
int[,] Matrix = new int[M, N];
PrintArray(FillArray(Matrix));
System.Console.WriteLine();
PrintArray(FillLastFerArray(Matrix));

int[,] FillLastFerArray(int[,] matrix)
{
    int[] arrayLastString = new int[N];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
       int temp=matrix[0,i];
       matrix[0,i]=matrix[matrix.GetLength(0)-1,i];
       matrix[matrix.GetLength(0)-1,i]=temp;
    }
    return matrix;
}

int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
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