
using System;

namespace VonRimmersmark {
public class Wight: IStabable, IDouseable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine("wtf is a wight, well either you just stabbed one");
        }
    }

    public void Douse(string attack)
    {
        if (attack == "Douse") {
            Console.WriteLine("water + Wight = good for ppl");
        }
    }
}
}