//71. Написать программу вычисления функции Аккермана 


int A(int m, int n)
{

    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return A(m - 1, 1);
    if (n > 0 && m > 0) return A(m - 1, A(m, n - 1));
    return A(n, m);
}

Console.WriteLine(A(3, 3));

