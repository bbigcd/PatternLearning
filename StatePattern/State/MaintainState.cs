using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.State
{
    public class MaintainState : IElevatorState
    {
        public void Close(Elevator elevator)
        {
            Console.WriteLine("设备维护中，已停止");
        }

        public void Maintain(Elevator elevator)
        {
            Console.WriteLine("设备维护中，已停止");
        }

        public void Open(Elevator elevator)
        {
            Console.WriteLine("设备维护中，已停止");
        }

        public void Run(Elevator elevator)
        {
            Console.WriteLine("设备维护中，已停止");
        }

        public void Stop(Elevator elevator)
        {
            Console.WriteLine("设备维护中，已停止");
        }
    }
}
