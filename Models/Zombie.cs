
using System;

namespace VonRimmersmark {
public class Zombie
{
    public void Burn (string attack) {
       if (attack == "Fire") {
            Console.WriteLine("Zombie dust");
        }
    }
}
}