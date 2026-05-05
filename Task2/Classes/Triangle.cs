using Tools;

namespace Task2.Classes;

public class Triangle
{
    private double SideA { get; set; }
    
    private double SideB { get; set; }
    
    private double SideC { get; set; }

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
    }

    public double Perimeter => SideA + SideB + SideC;
    
    public double Square()
    {
        var p = Perimeter / 2;

        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
}