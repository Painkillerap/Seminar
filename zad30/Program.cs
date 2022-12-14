/*
задача 48: Задайте двумерный массив размером m x n, каждый элемент в массиве находится по
формуле: Amn=m+n. Выведите полученный массив на экран.
 m = 3, n = 4.
 0 1 2 3
 1 2 3 4
 2 3 4 5
 */
 Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
int[,] Matrix = new int[M, N];
FillAndPrintArray(Matrix);


int [,] FillAndPrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =i+j ;
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
    return matrix;
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