using System;
using Module6lab;

namespace Module6Lab
{
    internal class SuperPlayer : Player
    {
        public SuperPlayer(string name) : base(name)
        {
        }

        public SuperPlayer(string name, int startingLives) : base(name, startingLives)
        {
        }

        // Additional properties or methods specific to SuperPlayer
        // For example:
        public void Fly()
        {
            Console.WriteLine("SuperPlayer is flying!");
        }
    }
}