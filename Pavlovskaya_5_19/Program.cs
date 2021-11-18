/* в одномерном массиве n
вычислить произведение отрицательных элементов массива
сумму положительных жлементов массива расположенных до максимального
изменить порядок следования элементов в массиве на обратный
*/

int GetRandom ()
{
  return new Random().Next(-100,100);
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {Console.Write($"{(array[i])} ");}
    Console.WriteLine();
}
int Proizv=1;

int Proizvedenie(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        {if (array[i]<0) Proizv=Proizv*array[i];}
    Console.WriteLine();
    return Proizv;
}


int i=0;
int[] A = new int [20];
int[] B = new int [20];
while (i<20)
{ A[i]=GetRandom(); i++; }
PrintArray(A);

// for (i = 0; i < A.Length; i++)
//         {if (A[i]<0) Proizv=Proizv*A[i];}
//     Console.WriteLine();
Proizvedenie(A);
Console.WriteLine ($"Произведение равно {Proizv}");

int sum=0;
int imax=0;
for (i = 0; i < A.Length; i++)
{if (A[i]>A[imax]) imax=i;}

int Sum (int [] array, int imax)
{for (i = 0; i < imax; i++)
        {if (array[i]>0) sum=sum+array[i];}
   
    return sum;
}


Console.WriteLine ($"Сумма равна {Sum(A, imax)}");

for (i = 0; i < A.Length; i++)    
{B[i]=A[19-i];}
PrintArray(B);
