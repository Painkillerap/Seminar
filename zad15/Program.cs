/*
Напишите программу, которая принимает на вход число (A) 
и выдает сумму чисел от 1 до А..
7 -> 28
4 -> 10
8 -> 36
*/
int N=InputNumber("Введите число N: ");
int result=SumN(N);
int B=InputNumber("Введите число B: ");
int result2=SumN(B);

System.Console.WriteLine($"Сумма чисел от 1 до {N} = {result}");
System.Console.WriteLine($"Сумма чисел от 1 до {B} = {result2}");

int InputNumber(string text)  //string  //int[]  //void  //bool
{
    System.Console.WriteLine(text);
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}


int SumN(int number)
{
    int result = 0;

    for (int i = 0; i <= number; i++)
    {
        result += i; // result=result+i
    }
    return result;
}

