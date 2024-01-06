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


// Console.ReadLine() - получить информацию из строчки Console.Write("Введите первое число: ");
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



/ Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&" - "И": яблоки И апельсины (и то, и другое нужно купить)
// "||" - "ИЛИ": яблоки ИЛИ апельсины(что-то одно, либо все вместе)
if (number >= 100 && number <= 999) // Число - трехзначное
{
    int firstDigit = number / 100; // 274 / 100 = 2
    int thirdDigit = number % 10; // 274 % 10 = 4
    int result = firstDigit * 10 + thirdDigit;
    // Интерполяция: $"Значение переменной {thirdDigit} = {}"
    Console.WriteLine($"Результат от числа {number} = {result}");
}
else // Число НЕ трехзначное
{
    Console.WriteLine("Число НЕ трехзначное");
}



// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10 % 10; // 487 / 10 % 10 = 48 % 10 = 8
    int thirdDigit = number % 10; // 487 % 10 = 7
    // Math.Pow(5, 2) => 5 в 2 степени => 25
    int result = (int)Math.Pow(secondDigit, thirdDigit);
    Console.WriteLine($"Число {number}: {secondDigit}^{thirdDigit} = {result}");
}
else // Число НЕ трехзначное
{
    Console.WriteLine("Число НЕ трехзначное");
}


/ Получите 3 цифру введенного числа слева (с начала)
// 1234567 => 3
// 7891 => 9
// 32 => 3 цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
if (number < 100) // Число не трехзначное
{
    Console.WriteLine("Третьей цифры нет :)");
}
else // Число трехзначное
{
    while (number > 999) // Если в числе минимум 4 цифры, я делю :)
    {
        number /= 10; 
    }
    Console.WriteLine($"Третья цифра от числа  {copyNumber} = {number % 10}");
}


// Получи третью цифру справа:
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
if (number < 100) // Число не трехзначное
{
    Console.WriteLine("Третьей цифры нет :)");
}
else // Число минимум трехзначное 
{
    int digitCount = 0; // Количество цифр, которое нужно убрать 
    int digit = 0; // Третья цифра справа
    while (digitCount < 2) // Отбрасываем 2 последние цифры
    {
        number /= 10;
        digitCount++; // digitCount = digitCount + 1
    }
    Console.WriteLine(number % 10);
}

int number = 123;
Console.WriteLine(number / 100 % 10);

