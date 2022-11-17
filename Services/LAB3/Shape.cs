namespace WebApplication1.Services.LAB3
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }

        public int GetArea(int x)
        {
            return Width * Height * x;
        }

        public int GetArea(double x)
        {
            return Width * Height * (int)x;
        }

        public virtual int GetShorterSide()
        {
            return new List<int>() { Width, Height }.Min();
        }

    }
}
