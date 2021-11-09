//27. Определить количество цифр в числе

int CountDigit(long n)

{
    
    int k=0;
    while(n!=0)
    {
        k++;
        n=n/10;
    }
    return k;
}
int a = Convert.ToInt32(Console.ReadLine());
int digits = CountDigit(a);

