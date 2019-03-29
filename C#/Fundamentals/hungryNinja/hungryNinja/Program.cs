using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet newBuffet = new Buffet();
            IConsumable snack = newBuffet.Serve();
            SweetTooth Jeremy = new SweetTooth();
            SpiceHound Cros = new SpiceHound();
            Cros.Consume(snack);
            Jeremy.Consume(snack);
            Jeremy.Consume(snack);
            Jeremy.Consume(snack);
            Jeremy.Consume(snack);
            Jeremy.Consume(snack);
            Jeremy.Consume(snack);
            Jeremy.Consume(snack);
        }
    }
}
