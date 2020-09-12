using System;

namespace ISP
{
    internal static class Program
    {
        private static void Main()
        {
            Operate(new MultiFunctionalCar());
            // Operate(new Car());
            // Operate(new Airplane());
        }

        private static void Operate(IVehicle vehicle)
        {
            vehicle.Drive();
            vehicle.Fly();
        }
    }
}
