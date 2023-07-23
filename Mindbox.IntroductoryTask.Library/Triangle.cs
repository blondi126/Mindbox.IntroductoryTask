namespace Mindbox.IntroductoryTask.Library;

public class Triangle : Shape
{
    public  double A { get; }
    public  double B { get; }
    public  double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Sides should be positive.");
        
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("The sum of any two sides should be greater than the third side.");

        A = a;
        B = b;
        C = c;
    }

    // Формула Герона
    public override double GetArea()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { A, B, C };
        Array.Sort(sides);
        
        // Учетываем возможную погрешность в вычислениях с числами с плавающей запятой
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1E-10;
    }
    
}
