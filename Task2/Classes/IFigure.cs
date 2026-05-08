namespace Task2.Classes;

public interface IFigure
{
    public FigureType Type { get; init; }

    public string ToString();
}