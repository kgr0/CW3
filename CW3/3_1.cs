
namespace CW3
{
    public abstract class Shape
    {
        public abstract int GetArea();
    }
    class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override int GetArea()
        {
            return Width * Height;
        }
    }
    class Square : Shape
    {
        public virtual int SideLength { get; set; }
       public override int GetArea()
        {
            return SideLength * SideLength;
        }
    }


}
