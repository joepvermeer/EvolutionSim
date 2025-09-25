using EvolutionSim.Core;

var cfg = new SimulationConfig(
    Width : 60,
    Height : 20,
    InitialOrganisms : 10,
    FoodSpawnRate : 2.0,
    FoodEnergy : 5.0,
    FoodSize : 1.0,
    MutationChance : 0.2
);

var world = new World(cfg);
var sim = new Simulation(world);
