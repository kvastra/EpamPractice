using Tools;

namespace Task2.Classes;

public class Triangle : IFigure
{
    private double SideA { get; }

    private double SideB { get; }
    
    private double SideC { get; }
    
    public FigureType Type { get; init; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0)
            throw new Exception(ErrorMessages.GetValueMustBePositiveError("Side 'a'"));

        if (b <= 0)
            throw new Exception(ErrorMessages.GetValueMustBePositiveError("Side 'b'"));

        if (c <= 0)
            throw new Exception(ErrorMessages.GetValueMustBePositiveError("Side 'c'"));

        if (a + b > c || a + c > b || b + c > a)
            throw new Exception(ErrorMessages.IncorrectValueOfSidesError);

        (SideA, SideB, SideC) = (a, b, c);
        Type = FigureType.Triangle;
    }

    public Triangle(double[] args) : this(args[0], args[1], args[2])
    {
    }

    public double Perimeter => SideA + SideB + SideC;
    
    public double Square()
    {
        var p = Perimeter / 2;

        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
    
    public override string ToString() => $"a = {SideA}, b = {SideB}, c = {SideC}, " +
                                         $"Perimeter = {Perimeter}, " +
                                         $"Square = {Square}";
}