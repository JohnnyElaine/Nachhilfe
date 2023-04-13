package Arrays;

import java.util.Locale;
import java.util.Random;

public class FloatZahlenArray {
    private float[] zahlen;
    private Random ran = new Random();

    public FloatZahlenArray() {
        this.zahlen = new float[15];

        float currVal = 1;
        for (int i = 0; i < this.zahlen.length; i++) {
            this.zahlen[i] = currVal;
            currVal += 0.5;
        }
    }

    public FloatZahlenArray(int anz) {
        if (anz < 10) anz = 10;

        this.zahlen = new float[anz];

        for (int i = 0; i < anz; i++) {
            this.zahlen[i] = genRandomFloat(1,10);
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

    public float summe() {
        float sum = 0;
        for (int i = 0; i < zahlen.length;i++) {
            sum += zahlen[i];
        }
        return sum;
    }

    private float genRandomFloat(float min, float max) {
        return min + ran.nextFloat() * (max - min);
    }

    public static void main(String[] args) {
        //anz = 25:
        FloatZahlenArray fArr1 = new FloatZahlenArray(25);
        fArr1.ausgeben();
        System.out.printf("Summe: " + fArr1.summe());

        System.out.println();

        //anz = leer:
        FloatZahlenArray fArr2 = new FloatZahlenArray();
        fArr2.ausgeben();
        System.out.printf("Summe: " + fArr2.summe());

        System.out.println();

        //anz < 10:
        FloatZahlenArray fArr3 = new FloatZahlenArray(3);
        fArr3.ausgeben();
        System.out.printf("Summe: " + fArr3.summe());
    }
}
