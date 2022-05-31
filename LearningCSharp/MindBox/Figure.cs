namespace LearningCSharp.MindBox;

public abstract class Figure
{
    public abstract double GetArea();
    public string Name { get; set; }

    public void PrintName()
    {
        Console.WriteLine($"{Name}");
    }
}