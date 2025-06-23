namespace Ovning5_Garage1._0
{
    public class Boat(string? registrationNumber, string? brand, int modelYear, string? color, int numberOfWheels, int lenght)
        : Vehicle(registrationNumber, brand, modelYear, color, numberOfWheels)
    {
        public int Lenght { get; } = lenght;

        public override string ToString()
        {
            return $"Regnr:{RegistrationNumber}\tMärke:{Brand}\tÅrsmodell:{ModelYear}\tFärg:{Color}" +
                $"\tAntal hjul:{NumberOfWheels}\tLängd:{Lenght}";
        }
    }
}
