namespace Tutorial.DesignPatterns.Visitor
{
    public class Multipolygon : Geometry
    {
        public Multipolygon() : base()
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}