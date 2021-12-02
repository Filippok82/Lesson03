// 41. Выяснить являются ли три числа сторонами треугольника 
int a, b, c;
Console.WriteLine ("Введите первое число");
a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите второе число");
b = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите третье число");
c = Convert.ToInt32(Console.ReadLine ());

string CheckTriangle (int a, int b, int c)
{
    string result=String.Empty;
    if (a+b>c && a+c>b && c+b>a) result=" Это стороны теругольника";
        else {result=result + $" Это не стороны треугольника";}
    return result;
}

Console.WriteLine(CheckTriangle(a, b, c));
