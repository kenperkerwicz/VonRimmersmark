
using System;

namespace VonRimmersmark {
public class Mummy : ICombustable
{
    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just burned the Mummy");
        }
    }
}
}