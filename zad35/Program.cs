/*
Задача 57: Составить частотный словарь элементов двумерного
 массива. Частотный словарь содержит информацию о том,
 сколько раз встречается элемент входных данных.
 */


 Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
int[,] Matrix = new int[M, N];
PrintArray(FillArray(Matrix));
System.Console.WriteLine();

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

int[] array=new int[10];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            array[Matrix[i,j]]+=1;
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]!=0)
        {
           System.Console.WriteLine($"Элемент {i} встречается {array[i]} раз");
        }
    }
/*
for (int k = 0; k < 10; k++)
{
    int count=0;
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            if(Matrix[i,j]==k)
            {
                count++;
            }
        }
    }
    if(array[k]!=0)
    {
       System.Console.WriteLine($"Элемент {k} встречается {count} раз");
    }
}
*/