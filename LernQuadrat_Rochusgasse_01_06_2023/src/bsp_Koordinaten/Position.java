package bsp_Koordinaten;

public class Position {
    private int x;
    private int y;

    public Position(){
        int x = 0;
        int y = 0;
    }

    public Position(int x, int y){
        this.x = x;
        this.y = y;
    }

    public int gehen(char[] weg){
        int xStart = x;
        int yStart = y;

        for (int i = 0; i < weg.length; i++) {
            if (weg[i] == 'N') y++;
            if (weg[i] == 'E') x++;
            if (weg[i] == 'S') y--;
            if (weg[i] == 'W') x--;
        }

        return Math.abs(xStart - x) + Math.abs(yStart - y);
    }

    public String positionToString(){
        return String.format("(%d, %d)", x, y);
    }

    public void positionAusgeben(){
        System.out.println(positionToString());
    }
}
