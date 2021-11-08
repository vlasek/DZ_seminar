//Найти третью цифру числа или сообщить, что её нет
int a=new Random().Next(1000);
Console.WriteLine ("Случайное число "+a);
if ((a>=100) && (a<1000)) Console.WriteLine ("Третья цифра "+a/100);
else {Console.WriteLine("Число не трехзначное  и третьей цифры нет");}


