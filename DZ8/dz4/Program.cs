/*
Задача 60. ...Сформируйте трёхмерный массив из двузначных
чисел. Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();
int M = InputNumber("Введите количество строк в массиве M: ");
int N = InputNumber("Введите количество столбцов в массиве N: ");
int T = InputNumber("Введите количество граней в массиве T: ");
int[,,] Matrix = new int[M, N, T];
System.Console.WriteLine();
PrintArray3D(FillArray3D(Matrix));

int[,,] FillArray3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
    return matrix;
}

void PrintArray3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"\n{matrix[i, j, k]} ({i},{j},{k}) \t ");
            }
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