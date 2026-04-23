namespace Task2.Classes;

public class Triangle
{
    private double SideA { get; set; }
    
    private double SideB { get; set; }
    
    private double SideC { get; set; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new Exception("All sides must have positive values.");

        if (a + b > c || a + c > b || b + c > a)
            throw new Exception("Incorrect value of sides: the sum of two sides must not be greater than the third.");

        (SideA, SideB, SideC) = (a, b, c);
    }

    public double Perimeter => SideA + SideB + SideC;

    public double Square()
    {
        var p = Perimeter / 2;

        return p * (p - SideA) * (p - SideB) * (p - SideC);
    }
}