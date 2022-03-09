using System;

namespace Tutorial.DesignPatterns.Visitor
{
    public class GeometryCenterVisitor : IVisitor
    {
        public void Visit(Geometry geometry)
        {
            double totalX = 0, totalY = 0, centerX = 0, centerY = 0;

            if (geometry.Points.Count>0)
            {
                foreach (var p in geometry.Points)
                {
                    totalX += p.X;
                    totalY += p.Y;
                }

                centerX = totalX/(geometry.Points.Count-1);
                centerY = totalY/(geometry.Points.Count-1);
            }

            Console.WriteLine("GeometryCenterVisitor : Center is X: " + centerX.ToString() +" , Y:" +centerY.ToString());
        }
    }
}