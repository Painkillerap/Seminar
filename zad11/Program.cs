int[] point = new int[2];
System.Console.WriteLine("Введите координату x: ");
point[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y: ");
point[1] = Convert.ToInt32(Console.ReadLine());

if (point[0] > 0 && point[1] > 0)
{
    System.Console.WriteLine("Точка лежит в первой четверти");
}
else if (point[0] > 0 && point[1] < 0)
{
    System.Console.WriteLine("Точка лежит в четвертой четверти");
}
else if (point[0] < 0 && point[1] < 0)
{
    System.Console.WriteLine("Точка лежит в третьей четверти");
}
else if (point[0] < 0 && point[1] > 0)
{
    System.Console.WriteLine("Точка лежит в второй четверти");
}
else 
{
    System.Console.WriteLine("Точка лежит на оси");
}
