using System;

namespace ISP
{
    public interface IDrive
    {
        void Drive();
    }

    public class Car : IDrive
    {
        public void Drive()
        {
            // actions to drive a car
            Console.WriteLine("Driving a car");
        }
    }
}
