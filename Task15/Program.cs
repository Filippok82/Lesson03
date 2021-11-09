// 15. Дано число. Проверить кратно ли оно 7 и 23

int a;
Console.WriteLine("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
if(a%7==0|a%23==0)
{
    Console.WriteLine("Данное число кратно 7 и 23!");
    
}
else {Console.WriteLine("Условие не выполняется.");}