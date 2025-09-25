using System;
using System.Collections.Generic;

namespace EvolutionSim.Core;

public sealed class World
{
    public int Tick { get; private set; }
    public SimulationConfig Config { get; }
    public Grid Grid { get; }
    public List<Organism> Organisms { get; } = new();
    public Random Rng { get; }

    public World(SimulationConfig config)
    {
        Config = config;
        Grid = new Grid(config.Width, config.Height);
        Rng = new Random(config.Seed);
    }

    public void NextTick() => Tick++; 
}