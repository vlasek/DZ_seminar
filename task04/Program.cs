//Найти максимальное из трех чисел

int GetRandom ()
{
  return new Random().Next(0,100);
}
int i=0; //лучше делать через for  так не будет проблем с реопредлением i
void PrintArray(int [] array)
{
while (i<3)
{
  Console.Write($"{(array[i])} ");
  i++;
}
}



i=0; 
int max=0;

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


PrintArray(A);

Console.WriteLine();
Console.WriteLine("Максимальное число "+ max);

