using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;

            // Create Circle
            Circle circle = new Circle(10,5);

            // Circle Upcast For Example
            Figure figure_circle = (Figure)circle;

            // Create Triangle
            Figure figure_triangle = new Triangle(4, 5, 6, 7);

            // Create Rectangle
            Figure figure_rectangle = new Rectangle(4, 6, 8, 3);

            // Create Ellipse
            Figure figure_ellipse = new Ellipse(4, 6, 8, 3);

            // Create Square
            Figure figure_square = new Square(4, 6);

            area = figure_circle.GetArea();
            Console.WriteLine("Circle area = "+ area);

            area = figure_triangle.GetArea();
            Console.WriteLine("Triangle area = "+ area);

            area = figure_rectangle.GetArea();
            Console.WriteLine("Rectangle area = "+ area);

            area = figure_ellipse.GetArea();
            Console.WriteLine("Ellipse area = " + area);

            area = figure_square.GetArea();
            Console.WriteLine("Square area = " + area);

            figure_circle.Display();
            figure_triangle.Display();
            figure_rectangle.Display();
            figure_ellipse.Display();
            figure_square.Display();


            Console.ReadKey();
        }
    }
}
