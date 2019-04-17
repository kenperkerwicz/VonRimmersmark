
using System;

namespace VonRimmersmark {
public class Wight: IStabable, IDouseable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine("You just stabbed the Wight");
        }
    }

    public void Douse(string attack)
    {
        if (attack == "Douse") {
            Console.WriteLine("You just doused the Wight");
        }
    }
}
}