//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int a=new Random().Next(10,99);

Console.WriteLine ("Случайное число " + a);
Console.WriteLine ("Первая цифра " + a/10);

Console.WriteLine ("Вторая цифра " + a%10);
