
//Показать вторую цифру трёхзначного числа
int a=new Random().Next(100,1000);

Console.WriteLine (a);
a=a/10;
Console.WriteLine (a%10);