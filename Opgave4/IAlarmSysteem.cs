using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    interface IAlarmSysteem
    {
        string AlarmDatumTijd { get; }
        string AlarmMelding { get; }

        void AddObserver( IAlarmObserver observer );
        void RemoveObserver( IAlarmObserver observer );
        void ActiveerAlarm( string melding );
    }
}
