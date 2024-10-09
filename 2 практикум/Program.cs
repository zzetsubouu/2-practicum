using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_практикум
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1
            //int a, b;
            //Console.Write("a= ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} = {a + b}\n{a} * {b} = {a * b}");

            //Task 1.2
            //int a, b;
            //Console.Write("a= ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} = {b} + {a}\n{a} * {b} = {b} * {a}");

            //Task 1.3 
            //int a, b, c;
            //Console.Write("a= ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c= ");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} + {c} = {a + b + c}");

            //Task 1.4
            //double a, b;
            //Console.Write("a= ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{a} * {b} = {a * b}");

            //Task 1.5
            //double a, b;
            //Console.Write("a= ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{a:N3} / {b:N3} = {a / b:N3}");

            //Task 1.6 
            //double a, b, c;
            //Console.Write("a= ");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("c= ");
            //c = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"({a:N2} + {b:N2}) + {c:N2} = {a:N2} + ({b:N2} + {c:N2})");

            //Task 1.7
            //int a, b;
            //Console.Write("a=");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b=");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"a + b = {a} + {b}={a + b}\ta - b = {a} - {b}={a - b}\ta * b = {a} * {b} = {a * b}");


            //Task 1.8
            //int a, b;
            //Console.Write("Номинал купюры=");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Колчество купюр=");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Сумма денег = {a * b:C}");

            //Task 2.1
            //Console.WriteLine("радиус окружности=");
            //int radius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Длина окружности = {Math.PI * radius}\n" +
            //                  $"Площадь круга = {Math.Pow(radius,2)*Math.PI} ");

            //TaskS 2.2
            //Console.Write("кол-во жителей=");
            //double villagers = Convert.ToDouble(Console.ReadLine());
            //Console.Write("площадь гос-ва (км^2)=");
            //double square = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Плотность населения = {villagers / square} человек/км^2");

            //task 2.3
            //double a, b, c;
            //Console.Write("katet 1=");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("katet 2=");
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.WriteLine($"периметр = {a + b + c}");

            //TASK 2.4
            //double a, b, diagonal;
            //Console.Write("Side 1=");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("side 2=");
            //b = Convert.ToInt32(Console.ReadLine());
            //diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.WriteLine($"Диагональ = {diagonal:N3} \nПериметр = {(a +b)*2}");

            //Task 2.5
            //int x1, x2, y1, y2;
            //Console.Write("x1=");
            //x1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("y1=");
            //y1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("x2=");
            //x2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("y2=");
            //y2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");


            //Task 2.6
            //Цена не фиксирована

            //int priceX, priceY, priceZ, x, y, z;
            //Console.Write("Введите стоимость 1 кг конфет:");
            //priceX = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите стоимость 1 кг печенья:");
            //priceY = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите стоимость 1 кг яблок:");
            //priceZ = Convert.ToInt32(Console.ReadLine());


            //Цена фиксирована

            //int x, y, z;
            //const int priceX = 10;
            //const int priceY = 8;
            //const int priceZ = 5;
            //Console.Write("Введите количество кг конфет:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите количество кг печенья:");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите количество кг яблок:");
            //z = Convert.ToInt32(Console.ReadLine());
            //int totalCost = (x * priceX) + (y * priceY) + (z * priceZ);
            //Console.WriteLine($"Стоимость всей покупки: {totalCost:C}");

            //Task 2.7
            //Console.WriteLine("Введите число:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int des = (number/10)%10;
            //int ed = number%10;
            //int sum = des+ed;
            //int umnozhenie = des*ed;
            //Console.WriteLine($"Число десятков: {des}\nЧисло единиц: {ed}\nСумма цифр: {sum}\nПроизведение цифр: {umnozhenie}");


        }
    }
}
