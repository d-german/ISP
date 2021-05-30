using System;

namespace ISP
{
    /// <summary>
    /// This class probably violates the SRP unless
    /// it implements the Facade design pattern.
    /// Where it delegates driving and flying behavior
    /// to other classes
    /// </summary>
    public class MultiFunctionalCar : IDrive, IFly
    {
        public void Drive()
        {
            // actions to drive a car
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            // actions to fly a car
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}
