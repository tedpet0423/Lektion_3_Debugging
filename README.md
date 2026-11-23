# Lektion 3 – Debugging

Ett litet konsolprogram i C# för att öva felsökning med debuggern.

## Kom igång

Öppna mappen i Rider eller Visual Studio, eller kör från terminalen:

    dotnet run

## Uppgifter

Uppgifterna finns som kommentarer i `Program.cs`.

**Del 1.** Programmet fyller en array med 30 tal (0, 5, 10 … 145).
Skriv ut alla värden med en `foreach`-loop.

**Del 2.** Programmet ska summera alla tal som är 100 eller större.
Rätt svar är 1225, men koden innehåller fel.

1. Sätt en brytpunkt i loopen och stega igenom koden.
2. Följ `j` och `sum` i debuggern och hitta varför resultatet blir fel.
3. Rätta felen så att programmet skriver ut `True`.
