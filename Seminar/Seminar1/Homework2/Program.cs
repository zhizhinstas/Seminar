// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Введите число a:");
string NumberString = Console.ReadLine();
int NumberA = Convert.ToInt32(NumberString);
Console.WriteLine ("Введите число b:");
NumberString = Console.ReadLine();
int NumberB= Convert.ToInt32(NumberString);
if (NumberA == NumberB)
{
    Console.WriteLine ("Числа равны");
}
else if (NumberA<NumberB)
{
    Console.WriteLine ($"a={NumberA} меньше b={NumberB}");
}
else
{
    Console.WriteLine ($"a={NumberA} больше b={NumberB}");
}