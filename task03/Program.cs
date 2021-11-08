//по заданному номеру дня недели вывести его название

int a;
Console.WriteLine ("Введите номер дня недели");
a = Convert.ToInt32(Console.ReadLine ());


// switch (s) вариает один с семинара
// {
//     case "1" Console.WriteLine ("Понедельник"); break;
//     case "1" Console.WriteLine ("Вторник"); break;
//       default Console.WriteLine ("Ошибочка вышла");}}}}}}
// }

// второй вариант
// string[] days=new string[8];
//days[1]="Понедельник"; а элемент ноль останется пустым
//days[2]="вторник";
//Console.WriteLine (days[days]);


if (a==1) Console.WriteLine ("Понедельник");{
if (a==2) Console.WriteLine ("Вторник");{
if (a==3) Console.WriteLine ("Среда");{
if (a==4) Console.WriteLine ("Четверг");{
if (a==5) Console.WriteLine ("Пятница");{
if (a==6) Console.WriteLine ("Суббота");{
if (a==7) Console.WriteLine ("Воскресенье");


if (a>8) Console.WriteLine ("Ошибочка вышла");}}}}}}