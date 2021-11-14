// 48. Создать игру "Угадай число"

Console.WriteLine("Угадай число от 1 до 100 за 7 попыток");
int n = new Random().Next(1,100);
int i = 0;

while (i<7)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());    
        if (a > n)
        {
            Console.WriteLine("Нужно меньше");
        }
        else if (a < n) 
        {
            Console.WriteLine("Нужно больше");
        }
        else if (a == n)
        {
            Console.WriteLine("УРА! Вы выиграли! За "+ (i+1) +" попыток"); 
            break;
            
        }
        i++;
       
    }
if (i==7) {Console.WriteLine("Вы проиграли");}
