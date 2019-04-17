
using System;

namespace VonRimmersmark {
public class Vampire : ICombustable,  IStabable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine("the vampire has been stabbed with the knife");
        }
    }

    public void Burn (string attack) {
       if (attack == "Fire") {
            Console.WriteLine("The fire makes the vampire burn");
        }
    }
}
}