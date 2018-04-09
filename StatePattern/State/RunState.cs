using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.State
{
    public class RunState : IElevatorState
    {
        public void Stop(Elevator elevator)
        {
            Console.WriteLine("电梯已停止，请选择下一步操作！");
            elevator.CurrentElevatorState = Elevator.StopState;
        }
        public void Open(Elevator elevator)
        {
            Console.WriteLine("电梯正在上升/下降，无法打开！");
        }
        public void Close(Elevator elevator)
        {
            Console.WriteLine("电梯正在上升/下降");
        }

        public void Run(Elevator elevator)
        {
            Console.WriteLine("电梯正在上升/下降！");
        }

        public void Maintain(Elevator elevator)
        {
            Console.WriteLine("设备运行中，无法进行维护");
        }
    }
}
