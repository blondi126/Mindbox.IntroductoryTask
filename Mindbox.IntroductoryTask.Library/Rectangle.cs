namespace Mindbox.IntroductoryTask.Library;

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0)
            throw new ArgumentException("Width must be positive.", nameof(width));

        if (height <= 0)
            throw new ArgumentException("Height must be positive.", nameof(height));

        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}