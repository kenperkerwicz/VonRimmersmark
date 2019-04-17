using System;

namespace VonRimmersmark
{
    class Program
    {
        static void Main(string[] args)
        {

             Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy();

            Ghoul ghouly = new Ghoul();

            Vampire dracula = new Vampire();

            Wight witty = new Wight();

            VonRimmersmark.Ignite(tuts);

             VonRimmersmark.WieldSilver(dracula);

             VonRimmersmark.SplashWater(ghouly);

             VonRimmersmark.WieldSilver(witty);




        }
    }
}
