/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Clear();
int N = InputNumber("Введите количество выводимых цифр: ");
int SIZE = N;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
int [] arr=FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
printArray(arr);
int PosN=PositivNumber(arr);

System.Console.WriteLine($"Количество цифр больше 0 равно: {PosN}");



int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] tempArr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArr;
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

int PositivNumber(int[] arr)
{
    {
    int count=0;
    for(int i = 0; i < arr.Length; i++)
    if(0<arr[i])
    {
       count++; 
    }       
    return count;
}
}

void printArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
}