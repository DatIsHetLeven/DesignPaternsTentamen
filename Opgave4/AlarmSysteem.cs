using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class AlarmSysteem : IAlarmSysteem
    {
        public string AlarmDatumTijd { get; private set; }
        public string AlarmMelding { get; private set; }

        List<IAlarmObserver> observers;

        public AlarmSysteem()
        {
            observers = new List<IAlarmObserver>();
        }

        public void ActiveerAlarm(string melding)
        {
            AlarmMelding = melding;
            AlarmDatumTijd = DateTime.Now.ToString();
            foreach ( var observer in observers )
                observer.Update();
        }

        public void AddObserver( IAlarmObserver observer )
        {
            observers.Add( observer );
        }

        public void RemoveObserver( IAlarmObserver observer )
        {
            observers.Remove( observer );
        }
    }
}
