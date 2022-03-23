using System;

namespace Project
{
    class MotorSport
    {
        //String color = "red";
        // int transmissionState = 0;
        // Double speedMax = 250;
        public Double speedCurrent = 0;
        public void go()
        {
            speedCurrent += 10;
        }

        public void turnLeft()
        {
            speedCurrent -= 2;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            MotorSport motorSport = new MotorSport();
            Console.WriteLine("current speed : " +
                              motorSport.speedCurrent);
            motorSport.go();//speed = 10
            Console.WriteLine("current speed : " +
                              motorSport.speedCurrent);
            motorSport.turnLeft();//speed = 8
            Console.WriteLine("current speed : " +
                              motorSport.speedCurrent);
            motorSport.go();//speed = 18
            Console.WriteLine("current speed : " +
                              motorSport.speedCurrent);
        }
    }
}
