namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle, ILandVehicle  // Electric motorcycle
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
            Console.WriteLine("Buzzzzzzzz");
        }
    }
}