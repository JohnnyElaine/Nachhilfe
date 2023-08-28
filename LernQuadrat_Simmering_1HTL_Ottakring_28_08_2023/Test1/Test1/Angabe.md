
Verwende die gegebene List<string> aus Main(). `List<string> inputList = Angabe.generateList();`. Diese Werten entsprechen Tiefenmessung aus einem U-Boot



# Aufgabe 1
Die gegebene Liste `inputList` enthält zahlen in string darstellung. Schreibe eine Methode die Werte aus `inputList` ganze Zahlen umwandelt und gib die resultierende Liste zurück. Die Liste mit den umgewandelten ganzzahligen Tiefenmessungen wird in Aufgaben 2 & 3 verwendet. 

# Aufgabe 2
Zähle wie oft eine Tiefenmessung gegenüber der vorherigen Messung zunimmt.

### Beispiel

Angenommen gegeben ist folgende Liste von Tiefenmessungen:

199,200,208,210,200,207,240,269,260,263

Im oberen Beispiel sind die Änderungen wie folgt:

- 199 (N/A - keine vorherige Messung)
- 200 (erhöht)
- 208 (erhöht)
- 210 (erhöht)
- 200 (verringert)
- 207 (erhöht)
- 240 (erhöht)
- 269 (erhöht)
- 260 (verringert)
- 263 (erhöht)

In diesem Beispiel gibt es `7` Messungen, die größer sind als die vorherige Messung.

Finde nun heraus wie wie viele Messung `inputList` größer sind als die vorherige Messung.

# Aufgabe 3

Die Betrachtung jeder einzelnen Messung ist nicht so nützlich, wie Sie erwartet haben.

Betrachten Sie stattdessen die Summen eines gleitenden Fensters mit drei Messungen. Wiederum unter Berücksichtigung des obigen Beispiels:

- 199  A      
- 200  A B    
- 208  A B C  
- 210    B C D
- 200  E   C D
- 207  E F   D
- 240  E F G  
- 269    F G H
- 260      G H
- 263        H


Vergleichen Sie zunächst das erste und das zweite Fenster mit drei Messungen. Die Messungen im ersten Fenster sind mit A (199, 200, 208) gekennzeichnet; ihre Summe beträgt 199 + 200 + 208 = 607. Das zweite Fenster ist mit B (200, 208, 210) gekennzeichnet; seine Summe beträgt 618. Die Summe der Messungen im zweiten Fenster ist größer als die Summe des ersten Fensters, so dass dieser erste Vergleich zugenommen hat.

Ihr Ziel ist es nun, zu zählen, wie oft sich die Summe der Messungen in diesem gleitenden Fenster gegenüber der vorherigen Summe erhöht. Vergleichen Sie also A mit B, dann B mit C, dann C mit D, und so weiter. Hören Sie auf, wenn nicht mehr genug Messungen übrig sind, um eine neue Summe von drei Messungen zu bilden.

Im Beispiel oben ist die Summe aller 3er-Gruppen wiefolgt:

- 199  A      
- 200  A B    
- 208  A B C  
- 210    B C D
- 200  E   C D
- 207  E F   D
- 240  E F G  
- 269    F G H
- 260      G H
- 263        H

---

- A: 607 (N/A - keine vorherige Summe)
- B: 618 (erhöht)
- C: 618 (keine veränderung)
- D: 617 (verringert)
- E: 647 (erhöht)
- F: 716 (erhöht)
- G: 769 (erhöht)
- H: 792 (erhöht)

In diesem Beispiel gibt es 5 Summen, die größer sind als die vorherige Summe.

Betrachten Sie die Summen eines gleitenden Fensters mit drei Messungen. Wie viele Summen sind größer als die vorherige Summe?