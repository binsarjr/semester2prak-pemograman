using System;

namespace TheCoffeMechine
{
    class Milk
    {
        private int volume = 0; // mililiter
        private int volumeOneCup = 100;
        public Milk(int volume)
        {
            this.volume = volume;
        }
        public bool isAvailable()
        {
            return this.volume >= volumeOneCup;
        }
        public void addMilk(int volume)
        {
            this.volume += volume;
        }

        public int makeOneCup()
        {
            this.volume -= this.volumeOneCup;
            return this.volumeOneCup;
        }

        public int getVolume()
        {
            return this.volume;
        }
    }
}
