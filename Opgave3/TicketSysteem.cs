using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    class TicketSysteem
    {
        Dictionary<string, int> tickets;

        static TicketSysteem instance;
        public static TicketSysteem Instance
        {
            get
            {
                if ( instance == null )
                {
                    instance = new TicketSysteem();
                }
                return instance;
            }
        }

        TicketSysteem()
        {
            tickets = new Dictionary<string, int>();
            tickets.Add( "Bruno Mars", 250 );
            tickets.Add( "Coldplay", 175 );
            tickets.Add( "Ed Sheeran", 150 );
        }

        public void PrintOverzicht()
        {
            Console.WriteLine( "Ticket overzicht" );
            Console.WriteLine( "Naam\tBedrag" );
            foreach( var i in tickets )
            {
                Console.WriteLine( i.Key + "\t" + i.Value );
            }
        }

        public void VerkoopTickets(string artiest, int aantal)
        {
            if ( !tickets.TryGetValue( artiest, out int oudAantal ) )
                return;

            int newAantal = oudAantal - aantal;
            if ( newAantal < 0 ) newAantal = 0;

            tickets[artiest] = newAantal;        
        }
    }
}
