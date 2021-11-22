// 42. Определить сколько чисел больше 0 введено с клавиатуры

int n=10;
int[] A = new int [n];

for (int i=0; i<n; i++)
{
    
    Console.Write($"Введите {i+1} число: ");
    A[i]= Convert.ToInt32 (Console.ReadLine());
}
int count=0;
for (int i=0; i<n; i++)
{
    if (A[i]>0) {count++;}
}
Console.WriteLine ($"число больше нуля встречается {count} раз");
