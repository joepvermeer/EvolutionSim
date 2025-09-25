namespace EvolutionSim.Core;

/* hier komen alle parameters die worden gebruikt. 
    ik stel ze nu op een paar random dingen in die ik van een vorig project ongeveer\
    had, maar die kloppen hoogswaarschijnlijk niet helemaal 
    als we gaan spelen met de variabelen, dan kan je ze hier dus aanpassen
 */
 
 /*
    ik heb moeite met de parameters van hoe voedsel wordt gegeten 
    ik wil hebben dat het wordt gegeten als de rand van een organisme de rand van een voedsel object aanraakt 
    dus organisme heeft iets van een straal = Size 
    voedsel heeft iets van straal = FoodSize
    dan eet hij hem op als afstand <= Size + FoodSize
 */

 public record SimulationConfig(
  // ruimte  
  double Width,
  double Height,

  // organismen
  int InitialOrganisms,

  //voedsel 
  double FoodSpawnRate,
  double FoodEnergy, // kunnen we misschien wel weglaten of gewoon als een Int weergeven 
  double FoodSize,

  //mutatie
  double MutationChance,
  int Seed = 100, 

  //energie
  double StartEnergy = 20, 
  double BaseMoveCost = 0.5, 
  double SpeedCostPerUnit = 0.5, 

  //snelheid (later grootte ook)
  double MinSpeed = 0.5, 
  double MaxSpeed = 5.0,

  //grootte 
  double DefaultSize = 1.0
); 