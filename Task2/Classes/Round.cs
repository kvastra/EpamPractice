using System.Drawing;

namespace Task2.Classes;

public class Round
{
    /// <summary>
    /// Координаты центра окружности
    /// </summary>
    private Point Center { get; set; }

    /// <summary>
    /// Радиус окружности
    /// </summary>
    private int Radius { get; set; }

    public Round(int x, int y, int radius)
    {
        if (radius <= 0)
            throw new Exception("Radius must have a positive value.");
        
        Center = new Point(x, y);
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