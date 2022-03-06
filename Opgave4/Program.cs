using System;

namespace Opgave4
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
            // maak alarmsysteem aan
            IAlarmSysteem alarmSysteem = new AlarmSysteem();

            // maak een controller aan
            IAlarmController alarmController = new AlarmController(alarmSysteem);

            // maak displays aan
            new AlarmDisplay( alarmSysteem );
            new AlarmExtendedDisplay( alarmSysteem );

            // activeer het alarmsysteem een paar keer (om te testen)
            alarmController.ActiveerAlarm( "achterdeur staat open" );
            Console.WriteLine();
            alarmController.ActiveerAlarm( "tocht bij raam 1e verdieping" );
            Console.WriteLine();
        }
    }
}
