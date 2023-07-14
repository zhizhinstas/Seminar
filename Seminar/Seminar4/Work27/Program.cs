//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int CountDigitNumRec(int num) 
{
    if ((num / 10) == 0) { return num; }
    else { return num % 10 + CountDigitNumRec (num / 10); }
}

int num;
while (true)
{
    Console.WriteLine("Программа сумму цифр.");
    Console.WriteLine("Введите число (0 - для выхода):");
    Int32.TryParse(Console.ReadLine(), out num);

    if (num == 0) { break; }
    if (num < 0) { num *= -1; }

    Console.WriteLine($"Сумма чисел равна {CountDigitNumRec(num)}");
}