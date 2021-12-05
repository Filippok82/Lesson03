//72. Написать программу возведения числа А в целую стень B

int SquaringNumber(int A, int B)
{
    return B == 0 ? 1 : SquaringNumber(A, B - 1) * A;
}
Console.WriteLine(SquaringNumber(5,6));