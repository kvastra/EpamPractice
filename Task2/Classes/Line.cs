namespace Task2.Classes;

public class Line: IFigure
{
    private double Ax { get; }
    
    private double Ay { get; }
    
    private double Bx { get; }
    
    private double By { get; }
    
    public FigureType Type { get; init; }

    public Line(double ax, double ay, double bx, double by)
    {
        Ax = ax;
        Ay = ay;
        Bx = bx;
        By = by;
        Type = FigureType.Line;
    }

    public Line(double[] args): this(args[0], args[1], args[2], args[3]){}

    public double Length => Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay));

    public override string ToString() => $"Line: " +
                                         $"a = ({Ax}, {Ay}), b = ({Bx}, {By}), " +
                                         $"Length = {Length}";
}