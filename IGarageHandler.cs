namespace Ovning5_Garage1._0
{
    internal interface IGarageHandler
    {
        bool IsGarage { get; }
        int NumberOfVehicles { get; }
  

        //void CreateGarage();
        string CreateGarage(string capacity);

        //void SeedData();
        string SeedData(int capacity);

        void ListAllVehicles();

        //void ParkVehicle();
        void ParkVehicle(int typeOfvehicle);

        void SetFields();
        bool CheckRegNumber(string registrationNumber);
        void AddVehicle(Vehicle vehicle);

        //void RemoveVehicle(string regNo);
        string RemoveVehicle(string regNo);

        void ListVehicleTypes();
        void Search();
        void PrintVehicles(string type, string brand, int modelYear, string color, int numberOfWheels);

        //string AvailableParkingSpaces();
        int AvailableParkingSpaces();
    }
}
