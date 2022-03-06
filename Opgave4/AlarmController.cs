using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class AlarmController : IAlarmController
    {
        IAlarmSysteem system;

        public AlarmController(IAlarmSysteem _system)
        {
            system = _system;
        }

        public void ActiveerAlarm( string melding)
        {
            system.ActiveerAlarm( melding );
        }
    }
}
