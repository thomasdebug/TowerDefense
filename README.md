# Sprint 0 - Game Design Document : Tower Defense
Naam: Thomas Born

Klas: SD2B

Datum: 08/09/2025

# 1. Titel en elevator pitch
Titel: Void kingdom 

Elevator pitch, maximaal twee zinnen: Beschrijf kort wat jouw game is en waarom het leuk is om te spelen.

Mijn game is een standaard towerdefense waarbij de voidking beschermt met de void torens. mijn game is leuk om te spelen want het heeft goeie replayablity.

# 2. Wat maakt jouw tower defense uniek
Beschrijf in één of twee zinnen wat jouw game onderscheidt van een standaard tower defense. Denk aan iets dat de speler op een nieuwe manier laat nadenken of spelen.

bij mijn game is er void damage hoe meer void damage je doet hoe meer currency je krijgt waarbij die voor upgrades kan gebruiken

# 3. Schets van je level en UI
Maak een schets op papier of digitaal en voeg deze afbeelding toe aan je repository. Voeg in deze sectie de afbeelding in.
![schets](schets.png)
Je schets bevat minimaal:

Het pad waar de vijanden over lopen met beginpunt en eindpunt.
De plaatsen waar torens gebouwd kunnen worden.
De locatie van de basis of goal die verdedigd moet worden.
De UI onderdelen geld, wave teller, levens, startknop en pauzeknop.
Een legenda met symbolen of kleuren voor torens, vijanden, pad, basis en UI.
# 4. Torens
Toren 1 naam, bereik, schade, unieke eigenschap.

void controller, groot, 6 damage per hit of 3 void damage(10% kans), het doet damage per tik in bursts zo een keer is 30/35 damage. 
Toren 2 naam, bereik, schade, unieke eigenschap.

void spiker, klein/medium, 40/50 damage of 20 void damage(10% kans), als een enemy wordt gespiked dan wordt hij slomer voor 5 sec.
Eventuele extra torens:

# 5. Vijanden
Vijand 1 naam, snelheid, levens, speciale eigenschap.
horror of normality, slow/medium, 100hp, hij heeft geen speciale eigenschappen maar wanneer hij 10 hp is wordt hij sneller met 50%
Vijand 2 naam, snelheid, levens, speciale eigenschap.

Eventuele extra vijanden:

# 6. Gameplay loop
Beschrijf in drie tot vijf stappen wat de speler steeds doet. 1.

# 7. Progressie
Leg uit hoe het spel moeilijker wordt naarmate de waves doorgaan. Denk aan sterkere vijanden, kortere tussenpozen, hogere kosten of lagere beloningen.

# 8. Risico’s en oplossingen volgens PIO
Probleem 1:

Impact:

Oplossing:

Probleem 2:

Impact:

Oplossing:

Probleem 3:

Impact:

Oplossing:

# 9. Planning per sprint en mechanics
Schrijf per sprint welke mechanics jij oplevert in de build. Denk aan voorbeelden zoals vijandbeweging over een pad, torens plaatsen, doel kiezen en schieten, waves starten, UI voor geld en levens, upgrades, jouw unieke feature.

Sprint 1 mechanics:

Sprint 2 mechanics:

Sprint 3 mechanics:

Sprint 4 mechanics:

Sprint 5 mechanics:

# 10. Inspiratie
Noem een bestaande tower defense game die jou inspireert en wat je daarvan meeneemt of juist vermijdt.

# 11. Technisch ontwerp mini
Lees dit korte voorbeeld en vul daarna jouw eigen keuzes in.

Voorbeeld ingevuld bij 11.1 Vijandbeweging over het pad

Keuze: Vijanden volgen punten A, B, C en daarna de goal.
Risico: Een vijand loopt een punt voorbij of blijft hangen.
Oplossing: Als de vijand dichtbij genoeg is kiest hij het volgende punt. Bij de goal gaat één leven omlaag en verdwijnt de vijand.
Acceptatie: Tien vijanden lopen van start naar de goal zonder vastlopers en verbruiken elk één leven. Alle tien vijanden bereiken achtereenvolgens elk waypoint binnen één seconde na elkaar.

### 11.1 Vijandbeweging over het pad
Keuze:

Risico:

Oplossing:

Acceptatie:

### 11.2 Doel kiezen en schieten
Keuze:

Risico:

Oplossing:

Acceptatie:
### 11.3 Waves en spawnen
Keuze:

Risico:

Oplossing:

Acceptatie:
### 11.4 Economie en levens
Keuze:

Risico:

Oplossing:

Acceptatie:
### 11.5 UI basis
Keuze:

Risico:

Oplossing:

Acceptatie: