//37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 200);
    Console.WriteLine(array[i] + " ");

}
for (int i = 0; i < array.Length; i++)
{
     if (array[i] < 99)
     {
        if (array[i] > 10)
         {
            Console.WriteLine( array[i] + " из отрезка [10,99]"); 
        }
    }
}

