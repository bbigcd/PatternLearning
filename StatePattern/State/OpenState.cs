using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.State
{
    public class OpenState : IElevatorState
    {
        public void Stop(Elevator elevator)
        {
            Console.WriteLine("电梯已停止，请选择下一步操作！");
        }
        public void Open(Elevator elevator)
        {
            Console.WriteLine("电梯已经打开，可以出入！");
        }
        public void Close(Elevator elevator)
        {
            Console.WriteLine("电梯已经关闭！，可以上下");
            elevator.CurrentElevatorState = Elevator.CloseState;
        }

        public void Run(Elevator elevator)
        {
            Console.WriteLine("电梯门开启，无法上升！");
        }


        public void Maintain(Elevator elevator)
        {
            Console.WriteLine("设备维护中，已停止");
            elevator.CurrentElevatorState = Elevator.MaintainState;
        }
    }
}
