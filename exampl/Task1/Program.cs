// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber < secondNumber)
// {
//     Console.Write("второе число больше");
// }
// else if (firstNumber > secondNumber)
// {
//     Console.Write("первое число больше");
// }
// else
// {
//     Console.Write("числа равны ");
// }

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    string PrintString = "";
    string CurrentString = " ";
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        CurrentString = currentDigit.ToString();
        if (N > 0)
        {
            PrintString = ("," + CurrentString  + PrintString);
        }
        else
        {
           
           PrintString = (CurrentString  + PrintString);
            Console.WriteLine(PrintString);
        }
    }
   // Console.WriteLine(printString);
}
