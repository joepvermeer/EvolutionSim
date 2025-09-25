using System.Collections.Generic;

namespace EvolutionSim.Core;

public sealed class Grid
{
    public double Width { get; }
    public double Height { get; }
    public List<Vec2> Food { get; } = new();

    public Grid(double width, double height)
    {
        Width = width;
        Height = height;
    }
    
    public int FoodCount => Food.Count;


}