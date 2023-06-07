namespace Garage
{
    public class Ram : Vehicle, IGasVehicle, ILandVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrentTankPercentage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void RefuelTank()
        {
            // method definition omitted
        }
        
        public void Drive()
        {
            Console.WriteLine("Bruuuubbbbbb!");
        }
          public void Stop()
        {
            Console.WriteLine("Can't stop a dodge bub!");
        }
    }
    }
