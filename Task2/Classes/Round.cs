using Tools;

namespace Task2.Classes;

public class Round : Figure
{
    /// <summary>
    /// X-координата центра окружности
    /// </summary>
    private double CenterX { get; set; }
    
    /// <summary>
    /// Y-координата центра окружности
    /// </summary>
    private double CenterY { get; set; }

    /// <summary>
    /// Радиус окружности
    /// </summary>
    private double Radius { get; set; }

    public Round(double x, double y, double radius)
    {
        if (radius <= 0)
            throw new Exception(ErrorMessages.GetValueMustBePositiveError("Radius"));

        CenterX = x;
        CenterY = y;
        Radius = radius;
    }
    
    /// <summary>
    /// Длина окружности
    /// </summary>
    /// <returns></returns>
    public double Perimeter => 2 * Math.PI * Radius;

    /// <summary>
    /// Площадь окружности
    /// </summary>
    /// <returns></returns>
    public double Square => Math.PI * Radius * Radius;
}