/* По двум заданным числам проверять является ли первое квадратом второго */

double a=64,b;
string s = Console.ReadLine();
b = Convert.ToInt32(s);
Console.WriteLine(Math.Pow(b,2));
if(a == Math.Pow(b,2))
{
    Console.WriteLine(a + " является квадратом числа " + (b));
} 
else
{
    
    Console.WriteLine(a + " не является квадратом числа " + (b));
}