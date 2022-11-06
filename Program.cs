using System;
using System.Collections.Generic;
using Figures;

namespace FigureExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Circle(new Distance(1)));
            figures.Add(new Circle(new Distance(2)));

            figures.Add(new Triangle(new Distance(3), new Distance(4), new Distance(5)));
            figures.Add(new Triangle(new Distance(1), new Distance(2), new Distance(2)));

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.EvaluateArea());
            }
        }
    }
}
