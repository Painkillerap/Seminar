/*
задача 46: Задайте двумерный массив размером m x n, заполненный случайными
 целыми числами.
 m = 3, n = 4.
 1 4 8 19
 5 -2 33 -2
 77 3 8 1
 */
Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
int[,] matrix = new int[M, N];
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
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