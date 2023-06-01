package bsp_Koordinaten;

public class TestPosition {
    public static void main(String[] args) {
        char[] weg1 = new char[]{'N','S', 'E', 'E'};
        char[] weg2 = new char[]{'N','N','N', 'E', 'E', 'S'};

        Position p1 = new Position();
        int distanz1 = p1.gehen(weg1);
        p1.positionAusgeben();
        System.out.println("Distanz:" + distanz1);

        distanz1 = p1.gehen(weg2);
        p1.positionAusgeben();
        System.out.println("Distanz:" + distanz1);


        Position p2 = new Position(-10,-5);
        int distanz2 = p2.gehen(weg2);
        p2.positionAusgeben();
        System.out.println("Distanz:" + distanz2);
    }
}
