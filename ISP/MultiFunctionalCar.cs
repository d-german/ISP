using System;

namespace ISP
{

    /// <summary>
    /// This class probably violates the SRP
    /// Since the code (responsibility) for driving will change for different times
    /// and for different reasons than the code for flying
    /// </summary>
    public class MultiFunctionalCar : IDrive, IFly
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

}
