using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    enum ProcessorType
    {
        i5,
        i7,
        Ryzen3
    }

    abstract class Laptop : IProcessor
    {
        private string serialNumber;
        public ProcessorType Processor;

        public Laptop(string _serialNumber, ProcessorType _processor )
        {
            serialNumber = _serialNumber;
            Processor = _processor;
        }

        public void Execute(string application)
        {
            Console.WriteLine( $"Executing program '{application}' with processor " + Processor );
        }
    }
}
