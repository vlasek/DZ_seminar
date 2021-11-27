// 54. В матрице чисел найти сумму элементов главной диагонали

void SetArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(1, 20);
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

void Task54(int[,] a, out int sum)
{
    sum = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {

            if (i == j) { sum = sum + a[i, j]; Console.Write($"{a[i,j]} + " );}
            
        }
    }
}

int m = 10;
int n = 10;
int[,] a;
a = new int[m, n];
int s;
SetArray2D(a);
Print(a);
Task54(a, out s);
Console.WriteLine($" сумма = {s}");




