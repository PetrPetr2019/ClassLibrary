using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2000
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Математическая библиотека которая вычисляет :Treangle, Circle, Rectangle, Trapeze.\n\t\t\t\t Для продолжения нажмите Enter");
       
            Console.WriteLine(" --------------------------------------------------------------------------------  ");
            Console.ReadLine();
            Console.WriteLine("Идет вычисление Треугольника:");
            ClassLibraryMatch.Triangle.Draw();
            Console.WriteLine("Идет вычисление круга:");
            ClassLibraryMatch.Circle.Draw();
            Console.WriteLine("Идет вычисление прямоугольника");
            ClassLibraryMatch.Rectangle.Draw();
            Console.WriteLine("Идет вычисление трапеции");
            ClassLibraryMatch.Trapeze.Draw();
     
            Console.ReadLine();
         
        }
    }
}
