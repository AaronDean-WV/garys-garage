namespace Garage
{
    public class Cessna : Vehicle, IAirVehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrentTankPercentage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public void Drive()
        {
            Console.WriteLine("The "+ MainColor + " Cessna zooms by!");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}