using System;

namespace Opgave2
{
    class Program
    {
        static void Main( string[] args )
        {
            Program p = new Program();
            p.Start();
        }

        private void Start()
        {
            PrintHeader( "MacBook" );
            Laptop macBook = new MacBook("S/N A1287");
            macBook.Execute( "virusscanner.exe" );

            PrintHeader( "HP" );
            Laptop hp = new HPLaptop("S/N 893419");
            hp.Execute( "virusscanner.exe" );

            PrintHeader( "changed MacBook" );
            macBook.Processor = ProcessorType.i7;
            macBook.Execute( "virusscanner.exe" );
        }

        private void PrintHeader( string header )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( header );
            Console.ResetColor();
        }
    }
}
