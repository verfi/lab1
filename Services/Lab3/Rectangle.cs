namespace WebApplication1.Services.Lab3
{
    public class Rectangle: Shape
    {
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
    }
}
