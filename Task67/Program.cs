// 67. Показать натуральные числа от N до 1, N задано
string Num (int M, int N)
{

    if (M <= N) return  Num (M + 1, N) + $"{M}" + " " ;
    else return String.Empty;
   
}
Console.Write(Num(1, 5));
