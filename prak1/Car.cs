class Car
{
    //String color = "red";
    // int transmissionState = 0;
    // Double speedMax = 250;
    public double speedCurrent = 0;
    public void go()
    {
        speedCurrent += 10;
    }

    public void turnLeft()
    {
        speedCurrent -= 2;
    }
}
