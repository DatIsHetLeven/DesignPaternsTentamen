using System;

namespace Opgave3
{
    class Program
    {
        static void Main( string[] args )
        {
            var ticket11 = TicketSysteem.Instance;
            var ticket2 = TicketSysteem.Instance;
            ticket11.PrintOverzicht();
            ticket2.VerkoopTickets( "Coldplay", 20 );
            ticket2.PrintOverzicht();
        }
    }
}
