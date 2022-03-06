using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class AlarmDisplay : IAlarmObserver
    {
        protected IAlarmSysteem system;

        public AlarmDisplay(IAlarmSysteem _system)
        {
            system = _system;
            _system.AddObserver( this );
        }

        public virtual void Update()
        {
            Console.WriteLine( "[alarm-display]: alarm geactiveerd om " + system.AlarmDatumTijd );
        }
    }
}
