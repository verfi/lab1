namespace WebApplication1.Services.LAB3
{
    public class Rectangle: Shape
    {
        public int Width2 { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public static int operator +(Rectangle a, Rectangle b)
        {
            var result = new Rectangle(a.Width + b.Width, a.Height + b.Height);
            return result.GetArea();
        }

        public override int GetShorterSide()
        {
            return 456;
        }
    }
}
