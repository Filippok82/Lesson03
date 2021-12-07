// 69. Найти сумму элементов от M до N, N и M заданы

/* int Sum(int M, int N)
{

    if (M<=N) return  N + Sum(M, N - M);
    else return 0;
   


}
Console.Write(Sum(1, 22));



 */

int SumRec(int n)
{
    if (n==0 || n<0) return 0;
    else return n+SumRec(n-1);    
}



System.Console.WriteLine(SumRec(-5));//-5 + -4+-3
                                     //1+2+3+4+5
