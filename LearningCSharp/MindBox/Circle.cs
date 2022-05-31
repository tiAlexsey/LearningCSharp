namespace LearningCSharp.MindBox;

public class Circle : Figure
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Radius * Math.PI;
    }
}