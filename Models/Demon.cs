
using System;

namespace VonRimmersmark {
public class Demon:  ICombustable,  IStabable, IDouseable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine(" Demon = stabbed w a knife");
        }
    }

    public void Douse (string attack)
    {
        if (attack == "Splash") {
            Console.WriteLine("the Demon was doused w water");
        }
    }

    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just burned the Demon to charcoal");
        }
    }
}
}