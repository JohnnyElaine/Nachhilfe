package Arrays;

import java.util.Random;

public class BooleanArray {

    private boolean[] werte;
    private Random ran = new Random();

    public BooleanArray() {
        werte = new boolean[15];

        for (int i = 0; i < werte.length ;i++) werte[i] = i % 2 != 0;
    }

    public BooleanArray(int anz) {
        if (anz < 10) anz = 10;
        werte = new boolean[anz];

        for (int i = 0; i < anz;i++) werte[i] = ran.nextBoolean();
    }

    public void ausgeben() {
        for (int i = 0; i < werte.length; i++) {
            if (i % 10 == 0 && (i != 0)) System.out.print('\n');

            System.out.print(werte[i]);

            if (i != werte.length - 1) System.out.print('\t');
        }
        System.out.println();
    }

    public int summe() {
        int sum = 0;
        for (int i = 0; i < werte.length;i++) if (werte[i]) sum++;

        return sum;
    }

    public static void main(String[] args) {
        //anz = 25:
        BooleanArray bArr1 = new BooleanArray(25);
        bArr1.ausgeben();
        System.out.printf("Summe: " + bArr1.summe());

        System.out.println();

        //anz = leer:
        BooleanArray bArr2 = new BooleanArray();
        bArr2.ausgeben();
        System.out.printf("Summe: " + bArr2.summe());

        System.out.println();

        //anz < 10:
        BooleanArray bArr3 = new BooleanArray(3);
        bArr3.ausgeben();
        System.out.printf("Summe: " + bArr3.summe());
    }
}
