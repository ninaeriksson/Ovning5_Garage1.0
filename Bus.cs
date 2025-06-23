namespace Ovning5_Garage1._0
{
    public class Bus(string? registrationNumber, string? brand, int modelYear, string? color, int numberOfWheels, int numberOfSeats)
        : Vehicle(registrationNumber, brand, modelYear, color, numberOfWheels)
    {
        public int NumberOfSeats { get; } = numberOfSeats;

        public override string ToString()
        {
            return $"Regnr:{RegistrationNumber}\tMärke:{Brand}\tÅrsmodell:{ModelYear}\tFärg:{Color}" +
                $"\tAntal hjul:{NumberOfWheels}\tAntal sittplatser:{NumberOfSeats}";
        }
    }
}
