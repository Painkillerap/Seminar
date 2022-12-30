/*
Задача 62. Напишите программу, которая заполнит спирально 
массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.Clear();
int M = 4;
int N = 4;
int[,] Matrix = new int[M, N];
PrintArray(FillArray0(Matrix));
PrintArray(FillArraySpiral(Matrix));

int[,] FillArraySpiral(int[,] matrix)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
    {
        Matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= Matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > Matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return matrix;
}


int[,] FillArray0(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 0);
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

