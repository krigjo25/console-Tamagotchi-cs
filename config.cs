using System;

namespace console_tamagotchi
{
    internal class Tamagotchi
    {
        //  Class fields
        private int _age_;
        private string _name_;
        private int _love_ = 100;
        private int _bleder_ = 100;
        private int _hunger_ = 100;
        

        // properties fields
        protected int LoveOMeter
        {
            get => _love_;
            set
            {
                // Ensure value > 0
                if (value > 0)
                {
                    _love_ = value;
                }
            }
        }
        public int Age
        {
            get; set;
        }

        protected int BlederOMeter
        {
            get => _bleder_;
            set
            {
                // Ensure value > 0
                if (value > 0)
                {
                    _bleder_ = value;
                }
            }
        }
        protected int HungerOMeeter
        {
            get => _hunger_;
            set
            {
                // Ensure value > 0
                if (value > 0)
                {
                    _hunger_ = value;
                }
            }
        }

        public string Name
        { get; set; }

        public Tamagotchi(string name, int age)
        {
            Age = age;
            Name = name;
            
        }
        public void FeedTamagotchi()
        {
            HungerOMeeter++;
            Console.WriteLine($"{Name} has been fed. {Name} is less hungry {HungerOMeeter}");

            return;
        }

        public void LoveTamagotchi()
        {
            LoveOMeter++;
            Console.WriteLine($"{Name} har blitt koset med");
        }

        public void GoWalk()
        {
            BlederOMeter--;
            Console.WriteLine($"You went for a walk with {Name}");
        }

        public void BarOMeter()
        {
            string love = "";
            string hunger = "";
            string bleder = "";


            for (int i = 0; i < LoveOMeter; i++)
            {
                love += "\u2593";
            }

            for (int i = 0; i < BlederOMeter; i++)
            {
                bleder += "\u2593";
            }

            for (int i = 0; i < HungerOMeeter; i++)
            {
                hunger += "\u2593";
            }

            Console.WriteLine($"Love : {love}\n");
            Console.WriteLine($"hunger : {hunger}\n");
            Console.WriteLine($" Bleder :{bleder}\n");
        }

    }
}