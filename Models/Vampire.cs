
using System;

namespace VonRimmersmark {
public class Vampire : ICombustable,  IStabable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine("You just stabbed the Vampire");
        }
    }

    public void Burn (string attack) {
       if (attack == "Burn") {
            Console.WriteLine("You just burned the Vampire");
        }
    }
}
}