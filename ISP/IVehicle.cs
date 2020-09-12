using System;

namespace ISP
{
    /// <summary>
    /// This violates the ISP
    /// </summary>
    public interface IVehicle
    {
        void Drive();
        void Fly();
    }

    /// <summary>
    /// This class probably violates the SRP
    /// Since the code (responsibility) for driving will change for different times
    /// and for different reasons than the code for flying
    /// </summary>
    public class MultiFunctionalCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            Console.WriteLine("Fly a multifunctional car");
        }
    }

    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }

        public void Fly() //we don't need to fly
        {
            throw new NotImplementedException();
        }
    }

    public class Airplane : IVehicle
    {
        public void Drive() // we don't need to drive
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
