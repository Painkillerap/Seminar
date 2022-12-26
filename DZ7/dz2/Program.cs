/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в
двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();
System.Console.WriteLine("Введите размер массива");
int M = InputNumber("Введите количество строк в массиве M: ");
int N = InputNumber("Введите количество столбцов в массиве N: ");
System.Console.WriteLine("Поиск Элемента массива");
int Y = InputNumber("Введите значение элемента в массиве Y: ");
int X = InputNumber("Введите значение элемента в массиве X: ");
int[,] Matrix = new int[M, N];
PrintArray(FillArray(Matrix));
Serch(Y, X);

void Serch(int Y, int X)
{
    if ((Y < 0 || X <0 )|| (Y > M || X > N))
        System.Console.WriteLine("Такого элемента массива нет! \nВведите новые значения элемента в массиве Y и X:");
    else
        System.Console.WriteLine($"Значение элемента в массиве равно: {Matrix[Y, X]}");
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

