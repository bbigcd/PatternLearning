using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface IElevatorState
    {
        void Stop(Elevator elevator);

        void Open(Elevator elevator);

        void Close(Elevator elevator);

        void Run(Elevator elevator);

        void Maintain(Elevator elevator);

    }
}
