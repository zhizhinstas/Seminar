// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int RekSumNum (int M, int N) { 
    if (M == N) return M;
    if (M > N) return 0;

    return M + N + RekSumNum(++M, --N);
}


while (true)
{
    int M = 0;
    int N = 0;
    Console.WriteLine("Введите число M: ");
    Int32.TryParse(Console.ReadLine(), out M);
    Console.WriteLine("Введите число N: ");
    Int32.TryParse(Console.ReadLine(), out N);

    if (M == 0 && N == 0) { break; }

    Console.WriteLine($"Сумма чисел от {M} до {N} - {RekSumNum(M, N)}");
}
