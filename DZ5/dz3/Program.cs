/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным
 элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
const int SIZE = 10;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
double [] arr=FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
printArray(arr);
double DiffNumber=DiffMaxMin(arr);
System.Console.WriteLine($"Разница между максимальным и минимальным значением массива равна: {DiffNumber}");

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] tempArr = new double[size];
    Random rand = new Random();
    for(int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = Math.Round(rand.Next(leftRange, rightRange + 1)+rand.NextDouble(),3);
    }
    return tempArr;
}

double DiffMaxMin(double[] arr)
{
    double Diff=0;
    double max=arr[0];
    double min=arr[0];
    for (int i = 0; i < arr.Length-1; i++)
    {   
        if (arr[i]<min)
        {
            min=arr[i];
        }
        if (arr[i]>max)
        {
            max=arr[i];
        }        
    }
    Diff=max-min;
    return Diff;
}

void printArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
}



