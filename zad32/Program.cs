/*
задача 51: Задайте двумерный массив размером. Найдите сумму элементов, находящихся на главной
диагонали(с индексами (0;0);(1;1) и т.д.)

 1 4 7 2      
 5 9 2 3      
 8 4 2 4      
 сумма элементов главной диагонали равна: 1+9+2=12
 */

  Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
PrintArray(SumDiag(M, N,out int result));
System.Console.WriteLine($"Сумма элементов главной диагонали равна: {result}");

int [,] SumDiag(int M, int N, out int result)
{
    result=0;
    int [,] matrix=new int[M,N];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =new Random().Next(-10, 10) ;
            if(i==j)
               result+=matrix[i,j] ;
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