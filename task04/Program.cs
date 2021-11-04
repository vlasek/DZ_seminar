//Найти максимальное из трех чисел

int GetRandom ()
{
  return new Random().Next(0,100);
}
int i=0, max=0;

int[] A = new int [3];
while (i<3)
{
A[i]=GetRandom();
i++;
}
i=0;
max=A[i];
while (i<3)
{
    if (A[i]>max) max=A[i];
    i++;
}
Console.Write ("В массиве: ");
i=0;
while (i<3)
{
    Console.Write(A[i]+ " ");
    i++;
}
Console.WriteLine();
Console.WriteLine("Максимальное число "+ max);

