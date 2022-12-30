/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();
int M = InputNumber("Введите количество строк в массиве M: ");
int N = InputNumber("Введите количество столбцов в массиве N: ");
int[,] Matrix = new int[M, N];
int[,] Matrix2 = new int[M, N];
PrintArrayMultiply(FillArray(Matrix), FillArray(Matrix2));
System.Console.WriteLine();
PrintArray(FillArrayMultiply(Matrix,Matrix2));

int[,] FillArrayMultiply(int[,] matrix, int[,] matrix2)
{
    int[,] MultiplyMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int a = 0; a < matrix2.GetLength(0); a++)
            {
                MultiplyMatrix[i, j] += matrix[i, a] * matrix2[a, j];
            }
        }
    }
    return MultiplyMatrix;
}

int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintArrayMultiply(int[,] matrix, int[,] matrix2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}  ");
        }
        Console.Write("| | ");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            System.Console.Write($"{matrix2[i, j]}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
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