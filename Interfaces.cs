// public interface IWalking
// {
//     void Run();
//     void Walk();
// }

// public interface ISwimming
// {
//     int MaximumDepth { get; }
//     void Swim();
// }

// public interface IFlying
// {
//     void Fly();
// }

using System;

namespace Garage
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }
       int CurrentTankPercentage { get; set;}
        void RefuelTank();
    }
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set;}
        void ChargeBattery();
    }
    public interface IWaterVehicle
    {
        double MaxWaterSpeed { get; set; }
        void Drive();
    }
    public interface ILandVehicle
    {
        double MaxLandSpeed { get; set; }
        void Drive();
    }
    public interface IAirVehicle
    {
        double MaxAirSpeed { get; set; }
        void Fly();
    }

}

