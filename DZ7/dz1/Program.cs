/*Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
double[,] Matrix = new double[M, N];
FillAndPrintArray(Matrix);
System.Console.WriteLine();



double[,] FillAndPrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 3);
            System.Console.Write($"{matrix[i, j]};\t");
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