/*
Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это
 невозможно, программа должна вывести сообщение для
 пользователя.
 */

Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");

int[,] Matrix = new int[M, N];
int[,] MatrixRev = new int[Matrix.GetLength(0), Matrix.GetLength(1)];
PrintArray(FillArray(Matrix));
PrintArray(FillReversArray(Matrix, MatrixRev));
System.Console.WriteLine();


int[,] FillReversArray(int[,] matrix, int[,] matrixrevers)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //int temp = matrix[i, j];
            matrixrevers[i, j] = matrix[j, i];
            //matrix[j, i] = temp;
        }
    }
    return matrixrevers;
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