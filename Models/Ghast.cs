
using System;

namespace VonRimmersmark {
public class Ghast : IStabable, IDouseable
{
    public void Stab (string attack)
    {
        if (attack == "Stab") {
            Console.WriteLine("the knife was used to stab the ghast");
        }
    }


    public void Douse (string attack) {
        if (attack == "Douse") {
            Console.WriteLine("the water makes the 'ghast' melt");
        }
    }


}
}