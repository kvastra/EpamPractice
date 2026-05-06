namespace Task2.Classes;

public class Ring: Figure
{
    /// <summary>
    /// Внешнее кольцо
    /// </summary>
    private Round OuterRound { get; set; }
    
    
    /// <summary>
    /// Внутреннее кольцо
    /// </summary>
    private Round InnerRound { get; set; }

    public Ring(double x, double y, double outerRadius, double innerRadius)
    {
        OuterRound = new Round(x, y, outerRadius);
        InnerRound = new Round(x, y, innerRadius);
        Type = FigureType.Ring;
    }

    public double Perimeter() => OuterRound.Perimeter + InnerRound.Perimeter;

    public double Square() => OuterRound.Square - InnerRound.Square;
}