package Labor16;

import java.util.Random;
import java.util.Scanner;

public class Spiel {

    private Scanner sc;
    private Random ran;

    /*
    Schere Stein Papier Matrix:
    Spalte = Meine Wahl
    Reihe = Wahl des Computers

    Schere = 1
    Stein = 2
    Papier = 3

     1 = Gewonnen
     0 = Unentschieden
     -1 = Verloren

    X       Schere      Stein       Papier
    Schere  Draw        Win         Loss
    Stein   Loss        Draw        Win
    Papier  Win         Loss        Draw

     */
    private static final int[][] winLossMatrix = new int[][] {
            {0,1,2,3},
            {1,0,1,-1},
            {2,-1,0,1},
            {3,1,-1,0}
    };

    private static final String[] schereSteinPapierIndex = new String[] {"", "Schere", "Stein", "Papier"};

    public void menue() {
        sc = new Scanner(System.in);
        ran = new Random();

        String menu = "Bitte wählen Sie\n" +
                "\t1 - für ein Würfelspiel\n" +
                "\t2 - für \"Schere-Stein-Papier\"\n" +
                "\t3 - Ausstieg aus dem Programm\n";

        int selection = 0;

        while (true) {
            System.out.println(menu);

            if (!sc.hasNextInt()) {
                System.out.println("Sie müssen eine Zahl eingeben");
                continue;
            }

            selection = sc.nextInt();

            if (selection < 1 || selection > 3) {
                System.out.println("Sie müssen eine Zahl zwischen 1 und 3 eingeben!");
                continue;
            }

            switch (selection) {
                case 1:
                    wuerfelSpiel();
                    break;

                case 2:
                    schereSteinPapier();
                    break;

                case 3:
                    sc.close();
                    System.exit(0);
                    break;
            }
        }
    }

    private int wuerfeln() {
        int z1 = genRandomInt(1, 7);
        int z2 = genRandomInt(1, 7);

        return Math.max(z1, z2) * 10 + Math.min(z1, z2);
    }

    private char readWuerfelSpielInput() {
        char userInput;
        while (true) {
            userInput = sc.next().charAt(0);
            if (userInput != '<' && userInput != '>' && userInput != '=') {
                System.out.println("Bitte geben sie eines der folgenden Symbole ein: <,>,=");
                continue;
            }
            break;
        }
        return userInput;
    }

    public void wuerfelSpiel() {
        int punkte = 0;
        int zahlNeu = 0;
        int zahlAlt = 0;
        boolean isGuessCorrect = true;
        boolean isFirstRun = true;

        while (true) {
            zahlNeu = wuerfeln();

            if (!isFirstRun) {
                char userInput = readWuerfelSpielInput();

                switch (userInput) {
                    case '<':
                        isGuessCorrect = zahlNeu < zahlAlt;
                        break;
                    case '>':
                        isGuessCorrect = zahlNeu > zahlAlt;
                        break;
                    case '=':
                        isGuessCorrect = zahlNeu == zahlAlt;
                        break;
                }

                if (isGuessCorrect) {
                    System.out.println("RICHTIG");
                    punkte++;
                } else {
                    System.out.printf("Leider falsch! -  die Zahl war %d%n", zahlNeu);
                    printPunkte(punkte);
                    break;
                }
            }

            zahlAlt = zahlNeu;


            System.out.printf("Die gewürfelte Zahl war %d%n", zahlNeu);
            System.out.printf("Wird die nächste Zahl >, < oder = %d sein?%n", zahlNeu);
            isFirstRun = false;
        }
    }

    public void schereSteinPapier() {
        String prompt = "Bitte geben Sie eines der Elemente ein:\n" +
                "\tSchere\n" +
                "\tStein\n" +
                "\tPapier\n";

        System.out.println(prompt);

        String userInput = sc.next();
        int computerWahl = genRandomInt(1,4);
        int meineWahl = 0;

        if (userInput.equals("Schere")) {
            meineWahl = 1;
        } else if (userInput.equals("Stein")) {
            meineWahl = 2;
        } else if (userInput.equals("Papier")) {
            meineWahl = 3;
        } else {
            System.out.println("Schreibfehler");
            return;
        }

        System.out.println(sspAuswerten(meineWahl, computerWahl));
    }

    /**
     *      * 1 = Gewonnen
     *      * 0 = Unentschieden
     *      * -1 = Verloren
     * @param meineWahl
     * @param computerWahl
     */
    private String sspAuswerten(int meineWahl, int computerWahl) {
        int ergebis = winLossMatrix[computerWahl][meineWahl]; // Ergebnis wird einfach der der Matrix ausgelesen

        switch (ergebis) {
            case -1:
                return String.format("Leider verloren - %s verliert gegen %s", schereSteinPapierIndex[meineWahl], schereSteinPapierIndex[computerWahl]);
            case 0:
                return String.format("Unentschieden - wir haben beide %s gewählt", schereSteinPapierIndex[meineWahl]);
            case 1:
                return String.format("Gewonnen - %s gewinnt gegen %s", schereSteinPapierIndex[meineWahl], schereSteinPapierIndex[computerWahl]);
        }

        return "Error";
    }

    private void printPunkte(int punkte) {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < punkte; i++) sb.append('*');

        System.out.println(sb);
    }

    private int genRandomInt(int min, int max) {
        return min + ran.nextInt(max - min);
    }
    public static void main(String[] args) {
        Spiel spiel = new Spiel();
        spiel.menue();
    }

}
