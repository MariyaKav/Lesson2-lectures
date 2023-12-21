// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет


// тип_данных имя_переменной = значение;
// camelCase: firstNumber, secondNumber
// int number = 9; // number = 9
// int result = number * number; // 81


// Console.ReadLine() - получить информацию из строчки
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// f = 25; s = 5: f == s*s, 25 == 5 * 5
if (firstNumber == secondNumber * secondNumber) //  a является кв от числа be
{
    Console.WriteLine("Да, " + firstNumber + " является кв. от числа " + secondNumber);
}
else // a не является кв от числа b
{
    Console.WriteLine("НЕТ, " + firstNumber + "  НЕ является кв. от числа " + secondNumber);
}
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// N = 4,
if (N < 0) // -5 * (-1) = 5
{
    Console.WriteLine("Введено отр. число N");
    N = N * -1;
}
int negativeN = N * -1; // -4


while (negativeN <= N) // -3 -2 -1 0 1 2 3
{
    Console.Write(negativeN + " ");
    negativeN++; // negativeN++ (negativeN = negativeN + 1)
}
