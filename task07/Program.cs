//Показать числа от -N до N

int GetRandom ()
{
  return new Random().Next(1,3000);
}

int a, b, c, i=0 ;
Console.WriteLine ("Введите начальный интервал");
a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите конченый интервал");
b = Convert.ToInt32(Console.ReadLine ());
//Console.WriteLine ("Введите количество элементов массива");
//с = Convert.ToInt32(Console.ReadLine ());

int[] A = new int [10];
while (i<10)
{
A[i]=GetRandom();
i++;
}


i=0;
//while (i<n){
while (i<10) 
{
    if ((A[i]>a) && (A[i]<b)) Console.Write(A[i]+" "); 
    i++;}

Console.WriteLine();


