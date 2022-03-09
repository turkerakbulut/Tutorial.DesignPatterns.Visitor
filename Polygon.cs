namespace Tutorial.DesignPatterns.Visitor
{
    public class Polygon : Geometry
    {
        public Polygon() : base()
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}