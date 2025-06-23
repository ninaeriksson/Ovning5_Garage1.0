namespace Ovning5_Garage1._0
{
    public class Car(string? registrationNumber, string? brand, int modelYear, string? color, int numberOfWheels, string fueltype)
        : Vehicle(registrationNumber, brand, modelYear, color, numberOfWheels)
    {
        public string FuelType { get; } = fueltype;

        public override string ToString()
        {
            return $"Regnr:{RegistrationNumber}\tMärke:{Brand}\tÅrsmodell:{ModelYear}\tFärg:{Color}" +
                $"\tAntal hjul:{NumberOfWheels}\tBränsle:{FuelType}";
        }
    }
}
