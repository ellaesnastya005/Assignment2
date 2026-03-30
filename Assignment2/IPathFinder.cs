namespace Assignment2.Generators;

public interface IPathFinder
{
    public (List<Point>, int) FindPath(string[,] map, Point start, Point destination);
}