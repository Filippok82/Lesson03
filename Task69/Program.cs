// 69. Найти сумму элементов от M до N, N и M заданы

int Sum(int M, int N)
{

    if (M<=N) return  N + Sum(M, N - M);
    else return 0;
   


}
Console.Write(Sum(1, 22));

