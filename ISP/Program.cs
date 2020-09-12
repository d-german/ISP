using System;

namespace ISP
{
    internal static class Program
    {
        private static void Main()
        {
            //Operate(new MultiFunctionalCar());
            TryOperate(new Car());
            TryOperate(new Airplane());
        }

        private static void Operate(IVehicle vehicle)
        {
            vehicle.Drive();
            vehicle.Fly();
        }

        private static void TryOperate(IVehicle vehicle)
        {
            try
            {
                vehicle.Fly();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                vehicle.Drive();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
