/*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.Clear();
int M = InputNumber("Введите количество строк в массиве M: ");
int N = InputNumber("Введите количество столбцов в массиве N: ");
int[,] Matrix = new int[M, N];
PrintArray(FillArray(Matrix));
System.Console.WriteLine();
PrintArray(DecreasingArray(Matrix));

int[,] DecreasingArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int a = 0; a < matrix.GetLength(1)-1; a++)
            {

                    if (matrix[i, a] < matrix[i, a+1])
                    {
                        int MinTemp = matrix[i, a];
                        matrix[i, a] = matrix[i, a+1];
                        matrix[i, a+1] = MinTemp;
                    }
            
            }
        }
    }
    return matrix;
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