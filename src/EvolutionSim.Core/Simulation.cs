namespace EvolutionSim.Core;

public sealed class Simulation
{
    private readonly World _w;
    public Simulation(World world)
    {
        _w = world;
        SeedInitial();
    }

    private void SeedInitial()
    {
        for (int i = 0; i < _w.Config.InitialOrganisms; i++)
        {
            var x = _w.Rng.NextDouble() * _w.Config.Width;
            var y = _w.Rng.NextDouble() * _w.Config.Height;
            var speed = 1.0;
            _w.Organisms.Add(new Organism(new Vec2(x, y), speed, _w.Config.StartEnergy));

        }
    }

    public void Step()
    {
        _w.NextTick();
    }
}