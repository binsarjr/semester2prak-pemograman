using System;
namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk milk;
        public CoffeMechine(Builder builder)
        {
            this.waterGalon = builder.waterGalon;
            this.coffePowder = builder.coffePowder;
            this.milk = builder.milk;
        }
        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your esspresso is ready";
        }

        public String makeCappucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if(this.milk is null) {
                return "Sorry, the milk is not ready";
            }
            if (!this.milk.isAvailable())
            {
                return "Sorry, the milk is empty";
            }
            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            this.milk.makeOneCup();

            return "Yeay! your cappuccino is ready";


        }

        public String checkAvailability()
        {
            String available = $"the water : {this.waterGalon.getVolume()} and the coffe powder : {this.coffePowder.getNetto()}";
            if (this.milk is Milk) {
                available += $" and the milk : {this.milk.getVolume()}";
            }
            return available;
        }

        public class Builder
        {
            public CoffePowder coffePowder;
            public WaterGalon waterGalon;
            public Milk milk;
            public Builder(CoffePowder coffePowder,WaterGalon waterGalon)
            {
                this.coffePowder = coffePowder;
                this.waterGalon = waterGalon;
            }

            public Builder withMilk(Milk milk)
            {
                this.milk = milk;
                return this;
            }

            public CoffeMechine build()
            {
                return new CoffeMechine(this);
            }

        }
    }
}
