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
            Console.WriteLine("Driving a car");
        }
    }
}
