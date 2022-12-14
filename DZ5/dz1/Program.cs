/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
const int SIZE = 10;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;
int [] arr=FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
int N=EvenNumber(arr);
printArray(arr);
System.Console.WriteLine($"Количество четных чисел равно: {N}");

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

int EvenNumber(int[] arr)
{
    int count=0;
    for(int i = 0; i < arr.Length; i++)
    if(arr[i]%2==0)
    {
       count++; 
    }
       
    return count;
}

void printArray(int[]arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}