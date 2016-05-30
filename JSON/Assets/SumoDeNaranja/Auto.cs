using System.Collections;

public class Auto
{
    private double x, y, speed;
    private int id;
    public Auto(double x, double y, int id)
    {
        this.x = x;
        this.y = y;
        this.id = id;
    }
    public void setSpeed(double speed)
    {
        this.speed = speed;
    }
    public double getX()
    {
        return this.x;
    }
    public double getY()
    {
        return this.y;
    }
    public double getSpeed()
    {
        return this.speed;
    }
    public int getId()
    {
        return this.id;
    }

}

