using System;

namespace Tutorial.DesignPatterns.Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Polygon polygon = new Polygon();
            polygon.Points.Add(new Point(0, 0));
            polygon.Points.Add(new Point(0, 10));
            polygon.Points.Add(new Point(10, 10));
            polygon.Points.Add(new Point(10, 0));
            polygon.Points.Add(new Point(0, 0));

            GeometryCenterVisitor geometryCenter = new GeometryCenterVisitor();

            polygon.Accept(geometryCenter);
            
            Console.Read();
        }
    }
}