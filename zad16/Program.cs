/*
Напишите программу, которая принимает на вход число 
и выдает количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*
System.Console.WriteLine("Введите число: ");
string number=Console.ReadLine();
int func(string number)
{
    return number.Length;
}
System.Console.WriteLine($"Количество цифр в введеном числе: {func(number)}");
*/
int result=inputNumber();
System.Console.WriteLine($"Количество цифр в введеном числе: {func(result)}");

int inputNumber()
{
    int number;
    string text;

    while(true)
    {
        System.Console.WriteLine("Введите число: ");
        text=Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

int func(int number)
{
    return Convert.ToString(number).Length;
}

