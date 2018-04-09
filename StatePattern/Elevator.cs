using StatePattern.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Elevator
    {
        public string ElevatorName { get; set; }

        public IElevatorState CurrentElevatorState { get; set; }

        public Elevator()
        {
            this.CurrentElevatorState = CloseState;
        }

        internal static IElevatorState StopState = new StopState();
        internal static IElevatorState CloseState = new CloseState();
        internal static IElevatorState OpenState = new OpenState();
        internal static IElevatorState RunState = new RunState();
        internal static IElevatorState MaintainState = new MaintainState();

        public void Stop()
        {
            this.CurrentElevatorState.Stop(this);
        }

        public void Open()
        {
            this.CurrentElevatorState.Open(this);
        }

        public void Close()
        {
            this.CurrentElevatorState.Close(this);
        }

        public void Run()
        {
            this.CurrentElevatorState.Run(this);
        }

        public void Maintain()
        {
            this.CurrentElevatorState.Maintain(this);
        }

    }
}
