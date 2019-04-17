
using System;

namespace VonRimmersmark {
public class Ghoul : IStabable, IDouseable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine("the ghoul has been stabbed with the knife");
        }
    }

    public void Douse (string attack) {
            if (attack == "Douse") {
            Console.WriteLine("Holy Water makes the Ghoul melt");
        }
    }
}
}