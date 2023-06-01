package bsp_2;

public class Kalender {
    private int jahr;
    private int monat_aktuell;
    private static final String [] monate = {"Jänner", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember"};

    public Kalender(int jahr, int monat_aktuell){
        this.jahr = jahr;
        this.monat_aktuell = monat_aktuell;
    }

    public void aktuelle_datum_anzeigen(){
        System.out.printf("%s %d%n", monate[monat_aktuell - 1], jahr);
    }

    public void naechster_monat(){
        if (monat_aktuell >= monate.length) jahr++;

        monat_aktuell = monat_aktuell % monate.length + 1;
    }

    public void vorheriger_monat(){
        monat_aktuell--;

        if (monat_aktuell < 1) {
            monat_aktuell = 12;
            jahr--;
        }
    }

    public void datum_aendern(int neuer_monat, int neues_jahr){
        monat_aktuell = neuer_monat;
        jahr = neues_jahr;
    }

    public boolean ist_schaltjahr(){
        return (jahr % 4 == 0 && jahr % 100 != 0) || jahr % 400 == 0;
    }
}
