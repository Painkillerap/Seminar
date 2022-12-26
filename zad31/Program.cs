/*
задача 49: Задайте двумерный массив размером. Найдите элементы у которых оба индекса нечетные
и замените эти элементы на их квадраты.

 1 4 7 2      1 4 7 2
 5 9 2 3      5 81 2 9
 8 4 2 4      8 4 2 4
 */

Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
int[,] Matrix = new int[M, N];
FillAndPrintArray(Matrix);
System.Console.WriteLine();
FillAndPrintArraySquare(Matrix);

int[,] FillAndPrintArraySquare(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
        }
    }
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]}; ");
            }
            System.Console.WriteLine();
        }
        return matrix;
    }
}

int[,] FillAndPrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
            System.Console.Write($"{matrix[i, j]}; ");
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