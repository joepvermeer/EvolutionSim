namespace EvolutionSim.Core;

public sealed class Organism
{
    public Vec2 Pos;
    public double Energy;
    public Traits Traits { get; } = new();


    public Organism(Vec2 pos, double speed, double energy)
    {
        Pos = pos;
        Energy = energy;
        Traits.Speed = Math.Max(0.0, speed); // kan niet negatief zijn, anders 0.0 en is hij dood
    }
}