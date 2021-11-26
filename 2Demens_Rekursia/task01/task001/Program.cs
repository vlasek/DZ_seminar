int [,] a; //описание массива cссылочный тип можно просто int[,] a=new int[4,5];
int N=9;
int M=7;
a=new int[N,M]; //

void SetArray2D(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=i*10+j;
        }
    }
}


void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    }
}

//Main
//int[,] a;//ссылочный тип (references)
//a=new int[10,4];

Print(a);
SetArray2D(a);
//Console.ReadKey();
//Console.Clear();
Print(a);

int s,m;
Task01(a, out s, out m);

// Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива.
void Task01(int[,], a, out int sum, out int multi)
{
    sum=0;
    multi=1;

}




//
void SetArray2D(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=i*10+j;
        }
    }
}


void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    }
}

// Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива
void Task01(int[,] a,out int sum,out int multi)
{
    sum=0;
    multi=1;

}

//Main
int[,] a;//ссылочный тип (references)
a=new int[10,4];

Print(a);
SetArray2D(a);
Console.ReadKey();
Console.Clear();
Print(a);
SetArray2D(a);
int s,m;
Task01(a,out s,out m);