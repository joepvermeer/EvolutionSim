README bestand voor Onderzoek simulatie Eolutie van Joep & Julian

werken in een C# .NET 9 bestand 

Gescheiden werken: 
EvolutionSim.Core = de motor van het bestand 
  -> een class library met alle domein logica: types, state, regels en algoritmes van onze simulatie (pure C# logica voor hergebruik 

EvolutionSim.App = de bestuurder 
  -> gewoon de console app (uitvoorbare programma) die Core bestand gebruikt. hier start je de installatie 

Runnend krijgen van programma: 
  -> dot net build 
  -> dotnet run --project src/EvolutionSim.App

Fases project: 
1. maak classes (leeg): Grid, Traits, Organism, World, Simulation, SimulationConfig
2. start programma met SimulationConfig
3. maak een World aan en initialiseer Simulation
4. laat Grid zichzelf opbouwen met gekozen b/h (kan later aangepast worden voor verschillende simulaties testen)
5. seeder aanmaken zodat de wereld begint met een begin populatie
6. maak een tick-loop in simulatie die de tijdseenheid stap voor stap behandeld
7. laat grid per #ticks een x aantal voedsel spawnen
8. geef elk organisme een random walk (zorgen dat hij wel op de grid blijft) met aantal stappen (dit wordt de snelheid)
9. laat voedsel op grid verdwijnen als een organisme het raakt (opeet) en vul voedsel van organisme aan met een bepaalde hoeveelheid (geen idee hoe we dit gaan doen)
10. per tick (tijdseenheid) gaat er energie (voedsel) af (basis + extra kosten tov snelheid organisme) 
11. verwijder dode organisme van grid (voedsel <= 0)
12. log de statistieken (populatie grootte, gemiddelde snelheid, mogelijk andere dingen als we willen)
13. voortplantingsregel moet ergens komen -> if voedsel >= drempel { kans = 0,02% per tijdseenheid op voortplanting }
14. bij voortplanting moet er een kleine kans zijn op mutatie van snelheid (later misschien dus groote). snelheid kan minder worden of meer 
15. verwekingsvolgorde -> per tick -> food spawn -> bewegen/eten/kosten -> voortplanten -> sterfte
16. voeg ASCII weergave toe voor de posities van organism en voedsel voor een grof raster
17. centraliseer alle parameters in SimulationConfig -> makkelijk om ze te wijzigen voor meerdere simulaties (populatie, gem grootte, gem snelheid, voedselpunten)
18. maak CLI-argumenten in de app om deze parameters en aantal ticks/runs aan te passen (toevoeging van chatGPT, geen idee wat hij bedoeld, maar ziet er belangrijk uit)
19. iets van een metrics verzameling
20. daarna dingen gaan schrijven zodat we metrics in een excel bestand of cvs bestand kunnen schrijven voor de grafieken
21. meer runs doen met verschillende parameters
22. deze readme aanpassen voor opstarten en handelen met variabelen, misschien wel zo handig
23. maak start experiment set -> eerste versie van simulatie
24. maak tweede experiment set -> food density aanpaseen
25. maak derde experiment set -> veld grootte aanpassen
26. kijken of alles met csv bestanden werkt
27. 

latere imlementaties voor uitbereidingen: 
- voeg kleur indicties toe; begin met een kleur (wit of grijs) -> basis organism. sneller? -> organisme roder. langzamer? -> organisme blauwer
- voeg trait toe van groote -> grotere kans om voedsel te treffen, maar kost meer voedsel om te leven
- herhaal experimenten met grootte implementatie

- 

