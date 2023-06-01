# Koordinaten 
Thema: 
- Wiederholdung Arrays
- Klassen
- Methoden mit/ohne Rückgabewert
- Character (char)
- Strings


## Aufgabe

Erstelle die Klasse `Position` die einen Punkt in einem 2-dimensionalen Koordinatensystem repräsentiert. 


### Methode: `gehen()`:
Ein objekt vom `Position` kann mit der Methode `gehen()` folgende Weg-Anweisungen einlesen und entsprechend die Position ändern:
- `N` - Gehe nach Norden (North)
- `E` - Gehe nach Osten (East) 
- `S` -  Gehe nach Süden (South)
- `W` -  Gehe nach Westen (West)

Ein Beispiel für eine Eingabe für die Methode `gehen()` ist ein char[], mit mehreren Weg-Anweisungen.
Beispielweise: char[] weg = {'N','N','S','S','E'}.

Die Methode `gehen()` gibt die Distanz zwischen dem Start-Punkt und dem End-Punkt zurück. Siehe [Manhattan-Metrik](https://de.wikipedia.org/wiki/Manhattan-Metrik).

Ein beispiel aufruf wäre:

```java
char[] weg = {'N','N','S','S','E'};
gehen(weg);
```

### Methode: `positionToString()`:
Die Methode `positionToString()` gibt die Momentane Positon als String zurück.

### Methode: `positionAusgeben()`:
Die Methode `positionAusgeben()` gibt die Momentane Positon auf der Konsole aus.

### Testen
Teste deine Klasse in `TestPosition`.

```java
```