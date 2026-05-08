using Task2.Classes;

class Program
{
    static void Main(string[] args)
    {
        var vgEditor = new VectorGraphicsEditor();
        
        vgEditor.CreateFigure(FigureType.Line, [2, 3, 4, 5]);
        vgEditor.CreateFigure(FigureType.Rectangle, [2, 3]);
        vgEditor.CreateFigure(FigureType.Round, [2, 3, 4]);
        vgEditor.CreateFigure(FigureType.Ring, [2, 3, 4, 5]);
        
        vgEditor.PrintFigures();
    }
}