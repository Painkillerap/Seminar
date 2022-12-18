/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива
с помощью поэлементного копирования.
*/
Console.Clear();
const int SIZE = 10;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
int [] arr=FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
int [] myArray_copy=CopyArray(arr); //myArray_copy = myArray[..];
printArray(arr);
printArray(myArray_copy);
int[] new_myArray_copy=arr[..];
arr[0]=200;
printArray(new_myArray_copy);

int[] array=CopyArray2(arr);
System.Console.WriteLine($"[{String.Join(", ",array)}]");


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

int [] CopyArray(int[] arr)
{
    int[] myArray = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        myArray[i]=arr[i];
    }
    return myArray;
}

int[] CopyArray2(int[] arr)
{
    int[] myArray={ };
    foreach (var item in arr)
    {
        myArray=myArray.Append(item).ToArray();
    }
    return myArray;
}



void printArray(int[]arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}