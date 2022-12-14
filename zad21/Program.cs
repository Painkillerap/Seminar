Console.Clear();
int Num=inputNumber();
const int SIZE = 15;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
System.Console.WriteLine();
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");

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