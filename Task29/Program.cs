// 29. Написать программу вычисления произведения чисел от 1 до N
;
//long f =1; // 2^64;
double F = 1;

for(int N =1;N<26;N++)
{
    F = 1;
for(uint i=1;i<N;i++)
{
   F = F*i;
}
Console.WriteLine("N "+ N + "F " + F);
}