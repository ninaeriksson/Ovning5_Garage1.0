namespace Ovning5_Garage1._0
{
    public abstract class Vehicle(string? registrationNumber, string? brand, int modelYear, string? color, int numberOfWheels)
    {
        public string? RegistrationNumber { get; } = registrationNumber;
        public string? Brand { get; } = brand;
        public int ModelYear { get; } = modelYear;
        public string? Color { get; } = color;
        public int NumberOfWheels { get; } = numberOfWheels;
    }
}
