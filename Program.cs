﻿namespace console_tamagotchi
{
    internal class ConsoleApp
    {

        public static void Main()
        {

            // Initializing an object
            Tamagotchi tama = new Tamagotchi("Kake navn", 25);

            tama.BarOMeter();

            tama.GoWalk();
            tama.FeedTamagotchi();
            tama.LoveTamagotchi();
        }
        
    }
}