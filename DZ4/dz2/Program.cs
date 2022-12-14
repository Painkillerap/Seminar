/*
Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
int N = inputNumber("Введите число: ");
int result = SumN(N);

System.Console.WriteLine($"Сумма цифр в числе {N} = {result}");

int SumN(int number)
{
    int result=0;
    while(number>0)
    {
    result+= number%10;
    number/=10;
    }
    return result;
}

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}