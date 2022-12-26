/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.Clear();
int M = InputNumber("Введите число M: ");
int N = InputNumber("Введите число N: ");
if (!Merge(N,M))
{
    Swap();
}
Number(N,M);

bool Merge(int n,int m) 
{
    if(n>m)
    return true;
    else
    return false;
}
void Swap()
{
    int temp=N;
    N=M;
    M=temp;
}

void Number(int n,int m)
{
    if (n==m-1)
    {
        return;
    }
 Number(n-1,m);
 System.Console.Write($" {n};");
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