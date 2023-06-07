namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle, ILandVehicle  // Electric car
    {
        public double BatteryKWh { get; set; }
        public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrentChargePercentage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        
        public void Drive()
        {
            Console.WriteLine("Veeeeeee!");
        }
    }
}