using System;

namespace TheBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball redBall = new Ball();
            redBall.setColor("red");
            Ball blueBall = new Ball();
            blueBall.setColor("blue");
            Ball yellowBall = new Ball();
            yellowBall.setColor("yellow");
            Ball orangeBall = new Ball();
            orangeBall.setColor("orange");
            Ball greenBall = new Ball();
            greenBall.setColor("green");
            Ball brownBall = new Ball();
            brownBall.setColor("brown");
            Ball purpleBall = new Ball();
            purpleBall.setColor("purple");
            Ball whiteBall = new Ball();
            whiteBall.setColor("white");
            Ball blackBall = new Ball();
            blackBall.setColor("black");
            Bucket bucket = new Bucket();
            bucket.addBall(redBall);
            bucket.addBall(blueBall);
            bucket.addBall(yellowBall);
            bucket.addBall(orangeBall);
            bucket.addBall(greenBall);
            bucket.addBall(brownBall);
            bucket.addBall(purpleBall);
            bucket.addBall(whiteBall);
            bucket.addBall(blackBall);
            Console.WriteLine("total : " + bucket.countTheBalls());

            Thermometer thermometer = new Thermometer();
            thermometer.celciusToFahrenheit(32);
            Console.WriteLine("hasil : " + thermometer.result());
//(32°C × 9/5) + 32 = 89.6°F
            thermometer.fahrenheitToCelcius(140);
            Console.WriteLine("hasil : " + thermometer.result());
//(140°F − 32) × 5/9 = 60°C
            thermometer.celciusToKelvin(3);
            Console.WriteLine("hasil : " + thermometer.result());
        }
    }
}
