using System;
using System.Collections.Generic;

namespace Tutorial.DesignPatterns.Visitor
{
    public enum GeometryTypes
    {
        Polygon = 0,
        MultiPolygon = 1
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public abstract class Geometry
    {
        public GeometryTypes Type { get; set; }

        public double Length { get; set; }

        public double Area { get; set; }

        public List<Point> Points { get; set; }

        public void GetVertexCount()
        { 
            Console.WriteLine("Geometry :" + Points.Count.ToString()); 
        }

        public abstract void Accept(IVisitor visitor);

        public Geometry()
        {
            Points= new List<Point>();
        }
    }
}