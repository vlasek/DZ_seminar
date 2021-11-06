//Определить, присутствует ли в заданном массиве, некоторое число


int GetRandom ()
{
  return new Random().Next(1,20);
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {Console.Write($"{(array[i])} ");}
    Console.WriteLine();
}

int a;
Console.WriteLine ("Введите число для проверки присутстивия в массиве (от 1 до 20)");
a = Convert.ToInt32(Console.ReadLine ());

int i=0;
int[] A = new int [20];
while (i<20)
{ A[i]=GetRandom(); i++; }

Console.WriteLine("Массив из 20 элементов");
PrintArray (A);
int count=0;
for (int j = 0; j < 20; j++)
{
    if (A[j]==a) {Console.WriteLine($"В массиве присутствуте число {a} и встречается на {j+1} позиции");count=count+1;}
}
    
while (count==0) {Console.WriteLine("Такого числа нет");break;}