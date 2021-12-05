// 68. Показать натуральные числа от M до N, N и M заданы

string Num (int M, int N)
{

    if (M <= N) return $"{M}" + " " + Num (M + 1, N);
    else return String.Empty;
   


}
Console.Write(Num(1, 5));
