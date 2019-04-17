
using System;

namespace VonRimmersmark {
public class Ghast : IStabable, IDouseable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine("You just stabbed the Ghast");
        }
    }


    public void Douse (string attack) {
        if (attack == "Douse") {
            Console.WriteLine("You just doused the Ghast");
        }
    }

    
}
}