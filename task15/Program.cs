//15. Дано число. Проверить кратно ли оно 7 и 23


int a=new Random().Next(100,1000);
Console.WriteLine(a);


if (a%7==0 && a%23==0) {Console.WriteLine("КРАТНО");}
