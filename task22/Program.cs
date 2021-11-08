//22 Найти расстояние между точками в пространстве 2D/3D
//c2=a2+b2

double Distanse(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
}
Console.WriteLine(Distanse(0,0,2,2));