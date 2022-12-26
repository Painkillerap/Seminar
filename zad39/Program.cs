/*
Задача 67: Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
Console.Clear();
int N = InputNumber("Введите число N: ");
System.Console.WriteLine($"Сумма цифр в числе равна: {SumNumber(N)}");

int SumNumber(int N)
{
    if (N<=0)
    {
        return 0;
    }
    int Sum=N%10+SumNumber(N/10);
    return Sum;
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