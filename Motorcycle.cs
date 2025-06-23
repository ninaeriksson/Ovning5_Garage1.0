namespace Ovning5_Garage1._0
{
    public class Motorcycle(string? registrationNumber, string? brand, int modelYear, string? color, int numberOfWheels, int cylinderVolume)
        : Vehicle(registrationNumber, brand, modelYear, color, numberOfWheels)
    {
        public int CylinderVolume { get; } = cylinderVolume;

        public override string ToString()
        {
            return $"Regnr:{RegistrationNumber}\tMärke:{Brand}\tÅrsmodell:{ModelYear}\tFärg:{Color}" +
                $"\tAntal hjul:{NumberOfWheels}\tCylindervolym:{CylinderVolume}";
        }
    }
}
