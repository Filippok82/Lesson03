// 22. Найти расстояние между точками в пространстве 2D

 double Distance2D(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
Console.WriteLine(Distance2D(0, 0, 2, 2)); 
 
// 22. Найти расстояние между точками в пространстве 3D

double Distance3D(double x1, double y1, double z1, double x2, double y2, double Z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(Z2 - z1, 2));
}
Console.WriteLine(Distance3D(0, 0, 0, 2, 2, 2));