
using System;

namespace VonRimmersmark {
public class Demon:  ICombustable,  IStabable, IDouseable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine("You just stabbed the Demon");
        }
    }

    public void Douse (string attack)
    {
        if (attack == "Splash") {
            Console.WriteLine("You just doused the Demon");
        }
    }

    public void Burn (string attack)
    {
        if (attack == "Burn") {
            Console.WriteLine("You just stabbed the Demon");
        }
    }
}
}