﻿// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
int GetNumber(string message)
    {
     int result = 0;

     while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))//23
        {
             break;
         }
         else
         {
             Console.WriteLine("Ввели не число. Повторите ввод");
         }
     }

     return result;
    }

 double Distance (int x1, int y1, int r1, int x2, int y2, int r2)
    {
     double dist = Math.Sqrt (Math.Pow((x1-x2),2) +Math.Pow((y1-y2),2) +Math.Pow((r1-r2),2));
     return dist; 
    }

 int x1 = GetNumber ("Введите значение x1");
 int y1 = GetNumber ("Введите значение y1");
 int r1 = GetNumber ("Введите значение r1");
 int x2 = GetNumber ("Введите значение x2");
 int y2 = GetNumber ("Введите значение y2");
 int r2 = GetNumber ("Введите значение r2");


 double result = Distance(x1, y1, r1, x2, y2, r2);
 Console.WriteLine($"расстояние между ними в 3D пространстве {result:0.###}");