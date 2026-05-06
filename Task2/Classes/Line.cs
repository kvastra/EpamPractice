namespace Task2.Classes;

public class Line: Figure
{
    private double Ax { get; }
    private double Ay { get; }
    private double Bx { get; }
    private double By { get; }

    public Line(double ax, double ay, double bx, double by)
    {
        Ax = ax;
        Ay = ay;
        Bx = bx;
        By = by;
        Type = FigureType.Line;
    }

    public double Length() => Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay));
}