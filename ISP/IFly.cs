using System;

namespace ISP
{
    public interface IFly
    {
        void Fly();
    }

    public class Airplane : IFly
    {
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
