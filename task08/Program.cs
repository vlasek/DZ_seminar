//Показать четные числа от 1 до N

int GetRandom ()
{
  return new Random().Next(0,1000);
}

int n, i=0, max=100;
Console.WriteLine ("Введите конченый интервал");
n = Convert.ToInt32(Console.ReadLine ());


int[] A = new int [max];
while (i<max)
{
A[i]=GetRandom();
i++;
}

i=0;
//while (i<n){
while (i<max) 
{
    if ((A[i]%2 ==0 && A[i]<n)) Console.Write(A[i]+" "); 
    i++;}

Console.WriteLine();