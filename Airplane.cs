namespace Ovning5_Garage1._0
{
    public class Airplane(string? registrationNumber, string? brand, int modelYear, string? color, int numberOfWheels, int numberOfEngines)
        : Vehicle(registrationNumber, brand, modelYear, color, numberOfWheels)
    {
        public int NumberOfEngines { get; } = numberOfEngines;

        public override string ToString()
        {
            return $"Regnr:{RegistrationNumber}\tMärke:{Brand}\tÅrsmodell:{ModelYear}\tFärg:{Color}" +
                $"\tAntal hjul:{NumberOfWheels}\tAntal motorer:{NumberOfEngines}";
        }
    }
}
