/*
Напишите программу, которая принимает на вход число N 
и выдает произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
int N = inputNumber();
System.Console.WriteLine($"Произведение чисел от 1 до {N} = {Fact(N)}");

int Fact(int n)
{
    int result=1;
    for (int i = 1; i <= n; i++)
    {
        result *= i; // result=result*i
    }
    return result;
}

int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine("Введите число: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
