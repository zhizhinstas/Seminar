// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 9
// m = 2, n = 3 -> A(m,n) = 29

int Akkerman(int M, int N) { 
    int tmp = 0;
    if (M == 0) return N + 1;
    else if (N == 0) { return Akkerman(M - 1, 1); }
    return tmp + Akkerman(M - 1, Akkerman(M, N - 1));

}

while (true)
{
    int M = 0;
    int N = 0;
    Console.WriteLine("Введите число M: ");
    Int32.TryParse(Console.ReadLine(), out M);
    Console.WriteLine("Введите число N: ");

    Int32.TryParse(Console.ReadLine(), out N);

    if (M == 0 && N == 0) 
    { break; }

    Console.WriteLine($"Функция Аккермана для чисел {M} и {N} = {Akkerman(M, N)}");
}
