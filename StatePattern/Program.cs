using System;

namespace StatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            elevator.Run();
            elevator.Run();
            elevator.Close();
            elevator.Run();
            elevator.Open();
            elevator.Run();
            elevator.Close();
            elevator.Run();
            elevator.Stop();
            elevator.Run();
            elevator.Maintain();
            elevator.Stop();
            elevator.Maintain();
            Console.ReadKey();
        }
    }
}
                                                  