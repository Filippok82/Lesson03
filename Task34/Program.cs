// 34. Написать программу замену элементов массива на противоположные 
int[] array = new int[10];
Random random = new Random();
for (int i = 0; i < array.Length; i++)

{
    array[i] = random.Next(-9, 25);

    Console.WriteLine(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)

{
    array[i] = array[i] * -1;

    Console.WriteLine(array[i]);
}

