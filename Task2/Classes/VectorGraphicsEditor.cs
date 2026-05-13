using Tools;

namespace Task2.Classes;

public class VectorGraphicsEditor
{
    private List<IFigure> Figures { get; } = [];
    
    public void CreateFigure(FigureType figureType, double[] args)
    {
        switch (figureType)
        {
            case FigureType.Line:
                if (args.Length != 4)
                    throw new Exception(ErrorMessages.IncorrectArgCountError);
                
                Figures.Add(new Line(args));
                break;
            
            case FigureType.Rectangle:
                if (args.Length != 2)
                    throw new Exception(ErrorMessages.IncorrectArgCountError);
                
                Figures.Add(new Rectangle(args));
                break;
            
            case FigureType.Round:
                if (args.Length != 3)
                    throw new Exception(ErrorMessages.IncorrectArgCountError);
                
                Figures.Add(new Round(args));
                break;
            
            case FigureType.Ring:
                if (args.Length != 4)
                    throw new Exception(ErrorMessages.IncorrectArgCountError);
                
                Figures.Add(new Ring(args));
                break;
            
            default:
                throw new Exception(ErrorMessages.IncorrectTypeError);
        }
    }

    public void PrintFigures()
    {
        foreach (var figure in Figures)
            Console.WriteLine(figure.ToString());
    }
}