//50. В двумерном массиве n×k заменить четные элементы на противоположные
void SetArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(1, 50);
        }
    }
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
}

void Task50(int[,] a)
{
   
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] % 2 == 0) { a[i,j]=-a[i,j];}
        }
    }
}

int m = 10;
int n = 5;
int[,] a;
a = new int[m, n];

SetArray2D(a);
Print(a);
Task50(a);
Console.WriteLine();
Print(a);



