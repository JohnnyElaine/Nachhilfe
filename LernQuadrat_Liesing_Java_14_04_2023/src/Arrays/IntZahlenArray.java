package Arrays;

import java.util.Random;

public class IntZahlenArray {
    private int[] zahlen;
    private Random ran = new Random();

    public IntZahlenArray(){
        this.zahlen = new int[15];

        int currValue = 10;
        for (int i = 0; i < this.zahlen.length;i++) {
            this.zahlen[i] = currValue;
            currValue += 5;
        }

    }
    public IntZahlenArray(int anz){
        if (anz < 10) anz = 10;

        this.zahlen = new int[anz];

        for (int i = 0; i < anz;i++) {
            this.zahlen[i] = 10 + this.ran.nextInt(90);
        }
    }

    public void ausgeben() {
        for (int i = 0; i < zahlen.length; i++) {
            if (i % 10 == 0 && (i != 0)) System.out.print('\n');

            System.out.print(zahlen[i]);

            if (i != zahlen.length - 1) System.out.print(',');
        }
        System.out.println();
    }

    public int summe() {
        int sum = 0;
        for (int i = 0; i < zahlen.length;i++) {
            sum += zahlen[i];
        }
        return sum;
    }

    public static void main(String[] args) {
        //IntZahlenArray:
        IntZahlenArray iArr1 = new IntZahlenArray(25);
        iArr1.ausgeben();
        System.out.printf("Summe: %d", iArr1.summe());

        System.out.println();

        IntZahlenArray iArr2 = new IntZahlenArray();
        iArr2.ausgeben();
        System.out.printf("Summe: %d", iArr2.summe());

        System.out.println();

        IntZahlenArray iArr3 = new IntZahlenArray(3);
        iArr3.ausgeben();
        System.out.printf("Summe: %d", iArr3.summe());
    }


}
