// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int n = new Random().Next(10, 99);
Console.WriteLine(n);
int s = n % 10;
int f = (n - s) / 10;
if (f > s)
{
    Console.WriteLine(f + " наибольшая цифра числа " + n);
}
else
{
    Console.WriteLine(s + " наибольшая цифра числа " + n);
}

 //Найти максимальное число в массиве
/* int FindMinMax(int[] input)
{
    
    int i = 0;
    int max = input[i];
    for (; i < input.Length; i++)
    
    {
        if (input[i] > max)
        {
            max = input[i];
        }
    }
    return max;
}

int[] NaturalArray(int minValue, int maxValue)
{
    int maxindex = maxValue-minValue+1;
    int[] newArray = new int[maxindex];
    for (int i = 0, n = minValue; i < maxindex; i++)
    {
        newArray[i] = n;
        n++;
    }
    return newArray;
}

int[] A = NaturalArray(10, 99);

Console.WriteLine($"Максимальное число в массиве {FindMinMax(A)}"); 
 */