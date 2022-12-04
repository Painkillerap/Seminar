int number= new Random().Next(10,100);
Console.WriteLine(number);
int num1=number/10;
int num2=number%10;
if(num1>num2)
{
    Console.WriteLine(num1);
    Console.WriteLine(num2);
}

