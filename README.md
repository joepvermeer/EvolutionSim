README bestand voor Onderzoek simulatie Eolutie van Joep & Julian

Gescheiden werken: 
EvolutionSim.Core = de motor van het bestand 
  -> een class library met alle domein logica: types, state, regels en algoritmes van onze simulatie (pure C# logica voor hergebruik 

EvolutionSim.App = de bestuurder 
  -> gewoon de console app (uitvoorbare programma) die Core bestand gebruikt. hier start je de installatie 

Runnend krijgen van programma: 
  -> dot net build 
  -> dotnet run --project src/EvolutionSim.App
