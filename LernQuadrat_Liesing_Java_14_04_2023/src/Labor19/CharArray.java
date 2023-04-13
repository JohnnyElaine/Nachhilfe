package Labor19;

import java.util.Arrays;

public class CharArray {
    char[] satz;
    int anz;

    CharArray (char[] satz) {
        this.anz = satz.length;
        this.satz = satz;
    }

    public void reverseZeile() {
        int endIndex = anz - 1;
        for (int i = 0; i < anz / 2; i++) {
            swap(i, endIndex - i);
        }
    }

    private void swap(int leftIndex, int rightIndex) {
        char tmp = satz[rightIndex];

        satz[rightIndex] = satz[leftIndex];
        satz[leftIndex] = tmp;
    }

    public void sort() {
        int end = anz - 1;

        int indexLargestElement;
        char largestElement;

        while (end > 0) {
            largestElement = 0;
            indexLargestElement = -1;

            for (int i = 0; i <= end; i++) {
                if (satz[i] > largestElement) {
                    largestElement = satz[i];
                    indexLargestElement = i;
                }
            }
            swap(indexLargestElement, end);
            end--;
        }
    }

    @Override
    public String toString() {
        return "CharArray{" +
                "satz=" + Arrays.toString(satz) +
                ", anz=" + anz +
                '}';
    }

    public static void main(String[] args) {
        CharArray c1 = new CharArray(new char[]{'a', 'b', 'c', 'd', 'e'});
        System.out.printf("Vor Reverse: %s%n", c1);
        c1.reverseZeile();
        System.out.printf("Nach Reverse: %s%n", c1);

        System.out.println();

        CharArray c2 = new CharArray(new char[]{'a', 'b', 'c', 'd', 'e', 'f'});
        System.out.printf("Vor Reverse: %s%n", c2);
        c2.reverseZeile();
        System.out.printf("Nach Reverse: %s%n", c2);

        System.out.println();

        CharArray c3 = new CharArray(new char[]{'z','b','a','a', 'Z', 'C', 'A', 'B'});
        System.out.printf("Vor Sortierung: %s%n", c3);
        c3.sort();
        System.out.printf("Nach Sortierung: %s%n", c3);
    }
}
