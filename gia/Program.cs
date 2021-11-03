// Напишите  программу,  которая  в  последовательности  натуральных  чисел 
// определяет минимальное число, оканчивающееся на 4. Программа получает 
// на  вход  количество  чисел  в  последовательности,  а  затем  сами  числа.  
// В последовательности всегда имеется число, оканчивающееся на 4. 
// Количество  чисел  не  превышает 1000. Введённые  числа  не  превышают  
// 30 000. 
// Программа должна вывести одно число – минимальное число, оканчивающееся 
// на 4.
// var
//   i, n, a, min: integer;
// begin
//   readln(n);
//   min := 30000;
//   for i := 1 to n do 
//   begin
//     readln(a);
//     if (a mod 10 = 4) and (a < min) then
//       min := a;
//   end;
//   writeln(min);
// end

int GetRandom ()
{
  return new Random().Next(100,30000);
}

int i=0, n, min=30000;
Console.WriteLine ("Введите количество чисел массива (не более 1000):");
n = Convert.ToInt32(Console.ReadLine ());

int[] A = new int [n];
while (i<n)
{
A[i]=GetRandom();
i++;
}
i=0;
while (i<n)
{
    if (((A[i]-4)%10==0) && (A[i]<min)) min=A[i];
    i++;
}
Console.WriteLine("Массив чисел: ");
i=0;
while (i<n)
{ Console.Write(A[i]+" "); i++;}

Console.WriteLine();

if (min!=30000) Console.WriteLine("Минимальное число, заканчивающиеся на 4 - это "+ min);
else {Console.WriteLine("В данном массиве таких чисел не найдено");};



