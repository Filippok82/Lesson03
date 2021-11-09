// 31. Задать массив из 8 элементов и вывести их на экран 
int[] array = new int[8];
Random random = new Random();
for (int i = 0; i < array.Length; i++)


    array[i] = random.Next(0, 100);

for (int i = 0; i < array.Length; i++)

    Console.WriteLine(array[i] + " ");
