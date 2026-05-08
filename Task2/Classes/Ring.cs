namespace Task2.Classes;

public class Ring: IFigure
{
    private Round OuterRound { get; }
    
    private Round InnerRound { get; set; }
    
    public FigureType Type { get; init; }

    public Ring(double x, double y, double outerRadius, double innerRadius)
    {
        OuterRound = new Round(x, y, outerRadius);
        InnerRound = new Round(x, y, innerRadius);
        Type = FigureType.Ring;
    }

    public Ring(double[] args) : this(args[0], args[1], args[2], args[3])
    {
    }

    public double Perimeter => OuterRound.Perimeter + InnerRound.Perimeter;

    public double Square => OuterRound.Square - InnerRound.Square;
    
    public override string ToString() => $"Ring: " +
                                         $"Perimeter = {Perimeter}, " +
                                         $"Square = {Square}";
}