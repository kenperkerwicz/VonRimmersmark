using System;

namespace VonRimmersmark
{
    class Program
    {
        static void Main(string[] args)
        {

             Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy();


            Vampire dracula = new Vampire();

            VonRimmersmark.Ignite(tuts);


             VonRimmersmark.WieldSilver(dracula);

             VonRimmersmark.Ignite(dracula);



        }
    }
}
