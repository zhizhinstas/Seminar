// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string PrintNum(int numb)
{
    string tmpstr = "";
    if (numb == 1) { return tmpstr = Convert.ToString(numb); }
    return tmpstr = Convert.ToString(numb) + ", " + PrintNum(numb - 1);
}

while (true)
{
    int numb = 0;
    Console.WriteLine("Введите число: ");
    Int32.TryParse(Console.ReadLine(), out numb);
    if (numb == 0) { break;}

    Console.WriteLine(PrintNum(numb));
}
