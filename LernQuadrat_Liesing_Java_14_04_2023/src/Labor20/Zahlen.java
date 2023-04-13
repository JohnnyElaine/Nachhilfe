package Labor20;

import java.util.Arrays;
import java.util.Random;

public class Zahlen {
    private int[] zahlen;
    private int anz;

    public Zahlen(int[] zahlen) {
        if (zahlen == null) {
            this.anz = 20;
            this.zahlen = new int[this.anz];
            Random ran = new Random();

            for (int i = 0; i < this.anz; i++) this.zahlen[i] = genRandomInt(20, 30, ran);

            return;
        }

        this.zahlen = zahlen;
        this.anz = this.zahlen.length;
    }

    public Zahlen(int anz) {
        if (anz <= 0) anz = 20;
        zahlen = new int[anz];
        this.anz = anz;
        Random ran = new Random();

        for (int i = 0; i < anz; i++) zahlen[i] = genRandomInt(10,99, ran);

        bubblesort();
    }

    public void ausgeben(int zeilenumbruch) {
        for (int i = 0; i < anz ;i++) {
            if (i % zeilenumbruch == 0 && (i != 0) ) System.out.print('\n');
            System.out.print(zahlen[i]);
            if (i != anz - 1) System.out.print(',');
        }
        System.out.println();
    }

    public int[] mehrfache() {

        int[] dup = new int[zahlen.length];
        int dupIndex = 0;

        for (int i = 0; i < zahlen.length; i++) {
            // Check ob zahlen[i] bereits in dup
            boolean isInDup = false;
            for (int j = 0; j < dup.length; j++) {
                if (dup[j] == zahlen[i]) {
                    isInDup = true;
                    break;
                }
            }

            if (isInDup) continue; // Überspringen wenn zahlen bereits in dup

            for (int j = 0; j < zahlen.length; j++) {
                if (i == j) continue;

                if (zahlen[i] == zahlen[j]) {
                    dup[dupIndex++] = zahlen[i];
                    break;
                }
            }
        }

        // 0er abscheiden:
        int [] finalDup = new int[dupIndex];
        for (int i = 0; i < finalDup.length ;i++) {
                finalDup[i] = dup[i];
        }

        return finalDup;
    }

    public int loesche(int zahl) {
        int count = 0;

        for (int i = 0; i < anz; i++) {
            if (zahlen[i] == zahl) {
                // verschiebe zahlen um eine stelle nach links
                for (int j = i; j < anz - 1;j++) {
                    zahlen[j] = zahlen[j + 1];
                }
                count++;
                anz--;
            }
        }

        return count;
    }

    /**
     * Fisher-Yates shuffle
     */
    public void mischen() {
        Random rand = new Random();

        for (int lastIndex = anz - 1; lastIndex > 0; lastIndex--) {
            int randIndex = genRandomInt(0, lastIndex, rand); // Zufälliger index innerhalb des noch nicht gemischten array teils

            swap(randIndex, lastIndex); // swap randIndex & lastIndex:
        }
    }

    public void ziffernsumme() {
        for (int i = 0; i < anz; i++) {
            int ziffernsumme = 0;
            int num = zahlen[i];

            while (num >= 1) {
                int digit = num % 10;
                ziffernsumme += digit;

                num /= 10;
            }

            System.out.printf("%d->%d%n",zahlen[i], ziffernsumme);
        }
    }

    public void shakerSort() {
        boolean isSorted = false;

        int top = anz - 1;
        int bottom = 0;

        while (!isSorted) {
            isSorted = true;

            // Links --> Rechts
            for (int i = bottom; i < top; i++) {
                if (zahlen[i] < zahlen[i + 1]) {
                    swap(i, i + 1);
                    isSorted = false;
                }
            }
            top--;

            if (isSorted) break;

            isSorted = true;
            // Links <-- Rechts
            for (int i = top; i > bottom; i--) {
                if (zahlen[i] > zahlen[i - 1]) {
                    swap(i, i - 1);
                    isSorted = false;
                }
            }
            bottom++;
        }
    }

    /**
     * Generiert ein Zufallszahl im angegebenen Bereich
     * @param min inklusive
     * @param max exklusive
     * @param ran random
     * @return Zufallszahl
     */
    private int genRandomInt(int min, int max, Random ran) {
        return min + ran.nextInt(max - min);
    }

    public void bubblesort() {
        int end = anz - 1;
        for (int i = 0; i < anz; i++) {
            for (int j = 0; j < end; j++) {
                if (zahlen[j] > zahlen[j + 1]) {
                    swap(j, j + 1);
                }
            }
            end--;
        }
    }

    private void swap(int left, int right) {
        int temp = zahlen[right];
        zahlen[right] = zahlen[left];
        zahlen[left] = temp;
    }

    @Override
    public String toString() {
        return "Zahlen{" +
                "zahlen=" + Arrays.toString(zahlen) +
                ", anz=" + anz +
                '}';
    }

    private static String arrToString(int [] a) {
        StringBuilder sb = new StringBuilder();
        sb.append('[');

        for (int i = 0; i < a.length ;i++) {
            sb.append(a[i]);
            if (i != a.length - 1) sb.append(',');
        }

        sb.append(']');

        return sb.toString();
    }

    public static void main(String[] args) {

        System.out.println("Test mehrfache: ");
        Zahlen z = new Zahlen(new int[]{15,27,14,15,18,25,53,15,27});

        z.ausgeben(100);

        int[] dup = z.mehrfache();
        System.out.println(arrToString(dup));
        System.out.println();

        System.out.println("Test Zahlen(int anz) sortiert: ");
        Zahlen z2 = new Zahlen(15);
        z2.bubblesort();
        z2.ausgeben(100);

        System.out.println();

        System.out.println("Test loesche: ");
        Zahlen z3 = new Zahlen(new int[]{15,27,14,15,18,25,53,15,27});
        System.out.println(z3);
        z3.loesche(15);
        System.out.println(z3);
        z3.loesche(27);
        System.out.println(z3);

        System.out.println();

        System.out.println("Test mischen(): ");
        Zahlen z4 = new Zahlen(15);
        System.out.printf("sortiert: %s%n", z4);
        z4.mischen();
        System.out.printf("nach mischen(): %s%n", z4);

        System.out.println("Test Ziffernsumme(): ");
        Zahlen z5 = new Zahlen(new int[]{17, 29, 98, 35});
        z5.ziffernsumme();

        System.out.println();

        System.out.println("Test shakerSort(): ");
        Zahlen z6 = new Zahlen(new int[]{5,6,3,2,555,1,123,1,9,8,25,76,998});
        System.out.printf("unsortiert: %s%n", z6);
        z6.shakerSort();
        System.out.printf("Nach shakersort(): %s%n", z6);
    }

}