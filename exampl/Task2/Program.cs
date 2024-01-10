// int max = 0;
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber > max)
// {
//     max = firstNumber;
// }
// if(secondNumber > max)
// {
//     max = secondNumber;
// }
// if(thirdNumber > max)
// {
//     max = thirdNumber;
// }

// Console.WriteLine("max = " + max);

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int a = number % 2;

// if(a == 0)
// {
//     Console.WriteLine("четное");
// }
// else
// {
//     Console.WriteLine("нечетное");
// }


//int max = 0;
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber % 7 == 0 && firstNumber % 23 == 0)
// {
//     Console.WriteLine("делится");
// }
// else
// {
//     Console.WriteLine("не делится");
// }

Console.Write("Введите координату x, не равную 0: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y, не равную 0: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая четверть");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("Начало координат");
}
else 
{
    Console.WriteLine("Одна из координат = 0");
}