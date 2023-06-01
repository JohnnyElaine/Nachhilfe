package bsp_1;

public class Konto {
    private String kontoinhaber;
    private double kontostand;

    public Konto(String kontoinhaber, double kontostand) {
        this.kontoinhaber = kontoinhaber;
        this.kontostand = kontostand;
    }

    public double einzahlen(double sum) {
        double tax = sum * 0.2;

        kontostand += sum - tax;

        return tax;
    }

    public double auszahlen(double sum) {
        if (kontostand - sum < 0) {
            System.out.println("Es ist nicht genug Geld auf dem Konto vorhanden, wählen Sie einen geringeren Betrag");

            // Falls ihr bereits Exceptions gelernt habt:
            //throw new ArithmeticException("Es ist nicht genug Geld auf dem Konto vorhanden, wählen Sie einen geringeren Betrag");
            return 0;
        }

        kontostand -= sum;

        return sum;
    }

    public void printDaten() {
        System.out.printf("Kontoinhaber: %s, Kontostnad: %.2f€ %n", kontoinhaber, kontostand);
    }
}
