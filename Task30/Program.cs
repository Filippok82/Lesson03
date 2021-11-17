//30. Показать кубы чисел, заканчивающихся на четную цифру
double[] arr = new double[10];


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 100);
}
double Cub = 0;
double a = 0;
for (int i = 0; i < arr.Length; i++)
{
    
    Cub = Math.Pow(arr[i],3);
    /* Console.WriteLine(Cub); */

    a = Cub%10;
     /* Console.WriteLine(a); */
     if(a%2==0)
     {
         Console.WriteLine( Cub);
     }
}
