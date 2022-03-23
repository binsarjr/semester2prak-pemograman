using System;

namespace Project
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Car lamborghini = new Car();
            Console.WriteLine("current speed : " +
                              lamborghini.speedCurrent);
            motorSport.go();//speed = 10
            Console.WriteLine("current speed : " +
                              lamborghini.speedCurrent);
            motorSport.turnLeft();//speed = 8
            Console.WriteLine("current speed : " +
                              lamborghini.speedCurrent);
            motorSport.go();//speed = 18
            Console.WriteLine("current speed : " +
                              lamborghini.speedCurrent);
        }
    }
}
