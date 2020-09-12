namespace ISP
{
    internal static class Program
    {
        private static void Main()
        {
            Operate(new MultiFunctionalCar() as IFly);
            Operate(new MultiFunctionalCar() as IDrive);

            Operate(new Car());
            Operate(new Airplane());
        }

        private static void Operate(IDrive vehicle)
        {
            vehicle.Drive();
        }

        private static void Operate(IFly vehicle)
        {
            vehicle.Fly();
        }
    }
}
