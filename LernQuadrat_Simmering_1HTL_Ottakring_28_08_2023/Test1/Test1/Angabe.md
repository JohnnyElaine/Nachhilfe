
Verwende die gegebene List<string> aus Main(). `List<string> inputList = Angabe.generateList();`. Diese Werten entsprechen Tiefenmessung aus einem U-Boot



# Aufgabe 1
Die gegebene Liste `inputList` enth�lt zahlen in string darstellung. Schreibe eine Methode die Werte aus `inputList` ganze Zahlen umwandelt und gib die resultierende Liste zur�ck. Die Liste mit den umgewandelten ganzzahligen Tiefenmessungen wird in Aufgaben 2 & 3 verwendet. 

# Aufgabe 2
Z�hle wie oft eine Tiefenmessung gegen�ber der vorherigen Messung zunimmt.

### Beispiel

Angenommen gegeben ist folgende Liste von Tiefenmessungen:

199,200,208,210,200,207,240,269,260,263

Im oberen Beispiel sind die �nderungen wie folgt:

- 199 (N/A - keine vorherige Messung)
- 200 (erh�ht)
- 208 (erh�ht)
- 210 (erh�ht)
- 200 (verringert)
- 207 (erh�ht)
- 240 (erh�ht)
- 269 (erh�ht)
- 260 (verringert)
- 263 (erh�ht)

In diesem Beispiel gibt es `7` Messungen, die gr��er sind als die vorherige Messung.

Finde nun heraus wie wiele Messung `inputList` gr��er sind als die vorherige Messung.

# Aufgabe 3

Die Betrachtung jeder einzelnen Messung ist nicht so n�tzlich, wie Sie erwartet haben.

Betrachten Sie stattdessen die Summen eines gleitenden Fensters mit drei Messungen. Wiederum unter Ber�cksichtigung des obigen Beispiels:

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


Vergleichen Sie zun�chst das erste und das zweite Fenster mit drei Messungen. Die Messungen im ersten Fenster sind mit A (199, 200, 208) gekennzeichnet; ihre Summe betr�gt 199 + 200 + 208 = 607. Das zweite Fenster ist mit B (200, 208, 210) gekennzeichnet; seine Summe betr�gt 618. Die Summe der Messungen im zweiten Fenster ist gr��er als die Summe des ersten Fensters, so dass dieser erste Vergleich zugenommen hat.

Your goal now is to count the number of times the sum of measurements in this sliding window increases from the previous sum. So, compare A with B, then compare B with C, then C with D, and so on. Stop when there aren't enough measurements left to create a new three-measurement sum.

In the above example, the sum of each three-measurement window is as follows:

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
- B: 618 (erh�ht)
- C: 618 (keine ver�nderung)
- D: 617 (verringert)
- E: 647 (erh�ht)
- F: 716 (erh�ht)
- G: 769 (erh�ht)
- H: 792 (erh�ht)

In diesem Beispiel gibt es 5 Summen, die gr��er sind als die vorherige Summe.

Betrachten Sie die Summen eines gleitenden Fensters mit drei Messungen. Wie viele Summen sind gr��er als die vorherige Summe?