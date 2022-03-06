using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class AlarmExtendedDisplay : AlarmDisplay
    {
        public AlarmExtendedDisplay(IAlarmSysteem _system):
            base(_system)
        {
        }

        public override void Update()
        {
            Console.WriteLine( "[extended alarm-display]: alarm geactiveerd om " + system.AlarmDatumTijd + " - " + system.AlarmMelding );
        }
    }
}
