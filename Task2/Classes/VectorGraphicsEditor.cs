using System.Text;

namespace Task2.Classes;

public class VectorGraphicsEditor
{
    private List<Figure> _figures { get; } = [];
    
    public void CreateFigure(FigureType figureType)
    {
        switch (figureType)
        {
            case FigureType.Line:
                break;
            case FigureType.Rectangle:
                break;
            case FigureType.Round:
                break;
            case FigureType.Ring:
                break;
            default:
                break;
        }
    }

    public void PrintFigures()
    {
        foreach (var figure in _figures)
            Console.WriteLine(GetFigureInfoString(figure));
    }

    private string GetFigureInfoString(Figure figure)
    {
        var sb = new StringBuilder();
        return sb.ToString();
    }
}