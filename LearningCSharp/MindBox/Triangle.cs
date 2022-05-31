namespace LearningCSharp.MindBox;

public class Triangle : Figure
{
    public double lineA { get; set; }
    public double lineB { get; set; }
    public double lineC { get; set; }
    
    
    public override double GetArea()
    {
        double p = GetHalfPerimeter();
        return Math.Sqrt(p * (p - lineA) * (p - lineB) * (p - lineC));
    }
    
    // Полупериметр
    private double GetHalfPerimeter()
    {
        return (lineA + lineB + lineC) / 2;
    }
}