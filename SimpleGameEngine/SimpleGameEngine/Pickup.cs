using System;

public class Pickup{
    private int maxX; //the maximum x position for our pickup
    private int maxY; //the maximum y position for our pickup
    private int x; //the current x position for our pickup
    private int y; //the current y position for our pickup
    private Random r = new Random();

    public Pickup(int maxX, int maxY){
        this.maxX = maxX;
        this.maxY = maxY;
        SetPosition();
    }

    public int X {
        get { return x; }
    }

    public int Y {
        get { return y; }
    }

    public void SetPosition(){
        x = r.Next(0, maxX);
        y = r.Next(0, maxY);
           
    }
}