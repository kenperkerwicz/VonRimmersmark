
using System;

namespace VonRimmersmark {
public class Ghoul : IStabable, IDouseable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine("You just stabbed the Mummy");
        }
    }

    public void Douse (string attack) {
            if (attack == "Douse") {
            Console.WriteLine("You just doused the Mummy");
        }
    }
}
}