// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
string numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);
numberInt = (numberInt / 10 % 10);
Console.WriteLine($"Вторая цифра: {numberInt}");