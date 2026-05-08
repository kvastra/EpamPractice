using System.Text;

namespace Task2.Classes;

public class VectorGraphicsEditor
{
    private List<IFigure> _figures { get; } = [];
    
    public void CreateFigure(FigureType figureType, double[] args)
    {
        switch (figureType)
        {
            case FigureType.Line:
                if (args.Length != 4)
                    throw new Exception();
                
                _figures.Add(new Line(args));
                
                break;
            case FigureType.Rectangle:
                if (args.Length != 2)
                    throw new Exception();
                
                _figures.Add(new Rectangle(args));
                break;
            case FigureType.Round:
                if (args.Length != 3)
                    throw new Exception();
                
                _figures.Add(new Round(args));
                break;
            case FigureType.Ring:
                if (args.Length != 4)
                    throw new Exception();
                
                _figures.Add(new Ring(args));
                break;
            default:
                break;
        }
    }

    public void PrintFigures()
    {
        foreach (var figure in _figures)
            Console.WriteLine(figure.ToString());
    }
}