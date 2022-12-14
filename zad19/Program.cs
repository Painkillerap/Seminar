// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

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

void SumOfNegativeAndPositiveNumber(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            sumP +=arr[i];
        }
        else
        {
            sumN+=arr[i];
        }
    }
}

const int SIZE = 5;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int[] arr = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
SumOfNegativeAndPotiveNumber(arr, out int sumP, out int sumN);

System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
System.Console.WriteLine($"Сумма положительных: {sumP}\nСумма отрицательных: {sumN}");
