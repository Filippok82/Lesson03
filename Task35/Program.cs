// 35. Определить, присутствует ли в заданном массиве, некоторое число 

 int[] array = new int[25];
Console.WriteLine("Какое число будем искать?");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 31);
    Console.Write(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)
{
    if (n == array[i])
    {
        Console.WriteLine("Число " +  n  + " найдено");
    }
            
}
    
