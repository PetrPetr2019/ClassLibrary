using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMatch
{

  
    public   class Triangle
             {
          static   public  void Draw()
        {
            double a, b, c, S;
            string temp = "";

            try
            {
              

                Console.WriteLine("Введите a");
                temp = Console.ReadLine();
                a = Convert.ToDouble(temp);
                Console.WriteLine("Введите b");
                temp = Console.ReadLine();
                b = Convert.ToDouble(temp);
                Console.WriteLine("Введите c");
                temp = Console.ReadLine();
                c = Convert.ToDouble(temp);
             // Проверка на то , является ли треугольник прямоугольным

                if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                    Console.WriteLine("Этот треугольник прямоугольный");
                else
                    Console.WriteLine("Не прямоугольный");
                double p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("Площадь равна" + S);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Вводите только числа");
                Console.ReadLine();
           
            
                return;
            }
            catch
            {
                throw;
            }
        }
   
    }
       public class Circle
        {
      static public void Draw()
        {
            double R;
            

            Console.WriteLine("Введите радиус круга");
            R = Convert.ToDouble(Console.ReadLine());
            R = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Площадь круга равна:{0}" + R);
            Console.ReadLine();
        }

       
    }
    public class Rectangle
    {
        static public void Draw()
        {
            double a, b, Slowed;
            Console.WriteLine("Введите сторону прямоугольника a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника b");
            b = Convert.ToDouble(Console.ReadLine());
            Slowed = (a * b);
            Console.WriteLine("Площадь прямоугольника" + Slowed);
            Console.ReadLine();
        }
    }
        
        public class Trapeze
        {
          static  public  void Draw()
            {
            Console.WriteLine("Идет вычисления Трапеции");
                double a, b, c, h;
                Console.WriteLine("Введите основание трапеции  a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите основание трапеции b");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту трапеции  h");
                h = Convert.ToDouble(Console.ReadLine());
                c = ((a + b) / 2) * h;
                Console.WriteLine("Площадь трапеции" + c);
                Console.ReadLine();
            }
        
        }


    public class Shape // Создание фигуры без знания типа фигуры
    {



        public Interfaces.IShape shape;
       
        public double Area => shape.Area;

        public  Shape(Interfaces.IShape figure)
        {
            shape = figure;
           
        }
    }
}
    namespace Interfaces
    {
        public class IShape
        {
            public double Area { get; internal set; }
        }
    }
      

