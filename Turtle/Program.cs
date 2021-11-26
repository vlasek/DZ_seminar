// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;
using Microsoft.SmallBasic.Library;

namespace TurtleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 10;
            int N = 6;
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    Turtle.Move(30);
                    Turtle.Turn(360 / N);
                }
                Turtle.Turn(60);
            }


        }
    }
}





using System;
using Microsoft.SmallBasic.Library;

namespace Test{
    class Program
    {
        static void Main()
        {
            Turtle.Speed=10;
          for(int i=0;i<4;i++)  
          {
          Turtle.Move(100);
          Turtle.TurnLeft();
          Turtle.Move(100);
          Turtle.TurnLeft();
          Turtle.Move(100);
          Turtle.TurnLeft();
          Turtle.Move(100);
          Turtle.TurnLeft();
          Turtle.Turn(90);
          }
        }
    }
}



// 42. Определить сколько чисел больше 0 введено с клавиатуры

int n=3;
int[] A = new int [n];

for (int i=0; i<n; i++)
{
    
    Console.Write($"Введите {i+1} число: ");
    A[i]= Convert.ToInt32 (Console.ReadLine());
}
int count=0;
for (int i=0; i<n; i++)
{
    if (A[i]>0) {count++;}
}
Console.WriteLine ($"число больше нуля встречается {count} раз");
от Андрей Заярный для Все (21:49)
using System;
using Microsoft.SmallBasic.Library;

namespace Test{
    class Program
    {
        static void Square(int len=50,double k=1)
        {        
            for(int i=0;i<4;i++)
            {
                 Turtle.Move(len*k);
                 Turtle.TurnLeft();                   
            }
        }
        static void Main()
        {
            Turtle.Speed=10;
          for(int i=0;i<4;i++)  
          {
            Square(100,i);          
          Turtle.PenUp();
          Turtle.Turn(135);
          Turtle.Move(50*i);
            Turtle.PenDown();
          Turtle.Turn(-135);
          }
        }
    }
}












using System;
using Microsoft.SmallBasic.Library;

namespace TurtleTest2
{
    class Program
    {
        static void РекурсивныйУзор(int x,int y,int r)
        {
            GraphicsWindow.DrawEllipse(x-r/2, y-r/2, r, r);
            if (r>30)
            {
                РекурсивныйУзор(x - r / 2, y, r / 2);
                РекурсивныйУзор(x + r / 2, y, r / 2);
                РекурсивныйУзор(x , y+r/2, r / 2);
                РекурсивныйУзор(x, y-r/2, r / 2);
            }

        }

        static void Main(string[] args)
        {
            GraphicsWindow.Width = 1000;
            GraphicsWindow.Height = 1000;
            РекурсивныйУзор(500, 500, 200);
        }
    }
}