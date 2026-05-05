using System.Drawing;
using Tools;

namespace Task2.Classes;

public class Round
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
    private int Radius { get; set; }

    public Round(double x, double y, int radius)
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
    public double Length => 2 * Math.PI * Radius;

    /// <summary>
    /// Площадь окружности
    /// </summary>
    /// <returns></returns>
    public double Square => Math.PI * Radius * Radius;
}