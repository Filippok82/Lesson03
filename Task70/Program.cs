// 70. Найти сумму цифр числа


int SumDigit(int a)
{

if(a==0) return 0;
else return a%10  + SumDigit(a/= 10);
}
Console.WriteLine(SumDigit(111111));