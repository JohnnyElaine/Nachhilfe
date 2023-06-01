package bsp_1;

import java.util.Arrays;

public class Finanzen {
    public static void main(String[] args) {
        Konto k1 = new Konto("Peter", 500.47);
        k1.printDaten();

        double tax = k1.einzahlen(200);
        k1.printDaten();
        System.out.printf("Bezhalte Steuer: %.2f %n", tax);

        k1.auszahlen(600);
        k1.printDaten();


        // Zu viel ausbezahlt:
        k1.auszahlen(9999);
        // Kontostand bleibt gleich
        k1.printDaten();
    }
}
