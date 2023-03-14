// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.Write("Введите трёхначное число: ");
int a = int.Parse(Console.ReadLine());
while (a < 100 || a > 999)
{
    Console.WriteLine("Вы ввели неверное число.");
    Console.Write("Введите трёхначное число: ");
    a = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Ваше число: {a}");
Console.WriteLine($"Вторая цифра вашего числа: {(a%100)/10}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("\nЗадача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string textNumber = Convert.ToString(number);
Console.WriteLine($"Ваше число: {number}");
if (textNumber.Length < 2)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine($"Третья цифра вашего числа: {textNumber[2]}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("\nЗадача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.Write("Введите день недели: ");
int x = int.Parse(Console.ReadLine());
while (x<1 || x>7)
{
    Console.WriteLine("Вы ввели неверное число");
    Console.Write("Введите день недели: ");
    x = int.Parse(Console.ReadLine());
}
if (x == 6 || x == 7)
    Console.WriteLine("Это выходной день");
