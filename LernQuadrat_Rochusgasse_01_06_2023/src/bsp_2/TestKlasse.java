package bsp_2;

public class TestKlasse {
    public static void main(String[] args) {
        Kalender kalender = new Kalender(2023, 6);

        kalender.datum_aendern(12, 2022);
        kalender.aktuelle_datum_anzeigen();
        kalender.naechster_monat();
        kalender.aktuelle_datum_anzeigen();
        kalender.vorheriger_monat();
        kalender.aktuelle_datum_anzeigen();
        System.out.println(kalender.ist_schaltjahr());

        System.out.println();

        //Schaltjahr:
        kalender.datum_aendern(2020,4);
        System.out.println(kalender.ist_schaltjahr());
    }
}
