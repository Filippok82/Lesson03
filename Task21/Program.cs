// 21. Программа проверяет пятизначное число на палиндромом.
/* Console.WriteLine("Ввведите пятизначное число:");
string s = Console.ReadLine();
int x, x1, x2, x3, x4;
x = Convert.ToInt32(s);
x1 = x % 10;
x2 = x/10%10;
x3 = x/1000%10;
x4 = x/10000%10;
if(x1==x4&&x2==x3)
{
   Console.WriteLine("Данное число является полиндромом");
}
else
{
   Console.WriteLine("Данное число  не является полиндромом");
}
 */

 string a = Convert.ToString(new Random().Next(10000,100000));
 Console.WriteLine(a);
 if(a[0]==a[4]&&a[1]==a[3]) Console.WriteLine("Данное число является полиндромом");
 else 
 Console.WriteLine("Данное число не является полиндромом");
 
