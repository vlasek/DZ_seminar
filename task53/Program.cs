// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента не


void SetArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(20, 40);
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

void Task53(int[,] a, int b, out int x1, out int y1)
{
    int x1=0;
    int y1=0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i,j] == a) { x1=i; y1=j; break;}
        }
    }
}

int m = 10;
int n = 5;
int[,] a;
a = new int[m, n];

SetArray2D(a);
Print(a);
Task53(a, 33, out x, out y);
Console.WriteLine($"Найденное число 33 имеет индекс {x} и {y}");




