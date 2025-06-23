using System.Data;

namespace Ovning5_Garage1._0
{
    public class GarageHandler : IGarageHandler
    {
        private IGarage<Vehicle>? myGarage;

        private string? input;
        private bool isGarage;

        private string? type;
        private string? registrationNumber;
        private string? brand;
        private int modelYear;
        private string? color;
        private int numberOfWheels;

        private int numberOfEngines;
        private int cylinderVolume;
        private string? fueltype;
        private int numberOfSeats;
        private int lenght;

        public bool IsGarage { get => isGarage; set => isGarage = value; }
        public int NumberOfVehicles => myGarage.Count();
        public int Capacity { get; private set; }


        //public void CreateGarage()
        //{
        //    Console.Write("Välj storlek på garaget: ");
        //    string? input = Console.ReadLine();
        //    try
        //    {
        //        int capacity = Int32.Parse(input);
        //        if (capacity < 1)
        //            throw new Exception();

        //        myGarage = new Garage<Vehicle>(capacity);
        //    }
        //    catch (Exception)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Ogiltig inmatning!");
        //    }
        //}

        public string CreateGarage(string input)
        {
            try
            {
                int capacity = Int32.Parse(input);

                if (capacity <= 0)
                    return $"Garage med {capacity} platser går inte att skapa.";
                if (capacity > 0)
                {
                    myGarage = new Garage<Vehicle>(capacity);
                    isGarage = true;
                    return $"Garage med {capacity} platser är nu skapat.";
                }
            }
            catch (Exception)
            {
                return "Ogiltig inmatning. Det måste vara 1 eller större.";
            }
            return "Något gick fel. Det gick inte att skapa ett garage.";
        }

        //public void SeedData()
        //{
        //    myGarage = new Garage<Vehicle>(20);

        //    Airplane airplane1 = new Airplane("abc123", "Airbus", 2020, "vit", 12, 4);
        //    Airplane airplane2 = new Airplane("def123", "Boeing", 2018, "vit", 10, 2);
        //    Motorcycle motorcycle1 = new Motorcycle("abc456", "BMW", 2022, "svart", 2, 500);
        //    Motorcycle motorcycle2 = new Motorcycle("def456", "Yamaha", 2023, "röd", 2, 1000);
        //    Car car1 = new Car("abc789", "Volvo", 2023, "grå", 4, "bensin");
        //    Car car2 = new Car("def789", "Volvo", 2001, "röd", 4, "bensin");
        //    Bus bus1 = new Bus("ghi123", "MAN", 2001, "blå", 8, 50);
        //    Bus bus2 = new Bus("ghi456", "Scania", 2011, "röd", 8, 40);
        //    Boat boat1 = new Boat("aaa111", "Nimbus", 2001, "vit", 0, 13);
        //    Boat boat2 = new Boat("aaa222", "Uttern", 2011, "grå", 0, 9);
        //    myGarage.Park(airplane1);
        //    myGarage.Park(airplane2);
        //    myGarage.Park(motorcycle1);
        //    myGarage.Park(motorcycle2);
        //    myGarage.Park(car1);
        //    myGarage.Park(car2);
        //    myGarage.Park(bus1);
        //    myGarage.Park(bus2);
        //    myGarage.Park(boat1);
        //    myGarage.Park(boat2);
        //}

        public string SeedData(int capacity)
        {
            try
            {
                myGarage = new Garage<Vehicle>(capacity);

                Airplane airplane1 = new Airplane("abc123", "airbus", 2020, "vit", 12, 4);
                Airplane airplane2 = new Airplane("def123", "boeing", 2018, "vit", 10, 2);
                Motorcycle motorcycle1 = new Motorcycle("abc456", "bmw", 2022, "svart", 2, 500);
                Motorcycle motorcycle2 = new Motorcycle("def456", "yamaha", 2023, "röd", 2, 1000);
                Car car1 = new Car("abc789", "volvo", 2023, "grå", 4, "bensin");
                Car car2 = new Car("def789", "volvo", 2001, "röd", 4, "bensin");
                Bus bus1 = new Bus("ghi123", "man", 2001, "blå", 8, 50);
                Bus bus2 = new Bus("ghi456", "scania", 2011, "röd", 8, 40);
                Boat boat1 = new Boat("aaa111", "nimbus", 2001, "vit", 0, 13);
                Boat boat2 = new Boat("aaa222", "uttern", 2011, "grå", 0, 9);
                myGarage.Park(airplane1);
                myGarage.Park(airplane2);
                myGarage.Park(motorcycle1);
                myGarage.Park(motorcycle2);
                myGarage.Park(car1);
                myGarage.Park(car2);
                myGarage.Park(bus1);
                myGarage.Park(bus2);
                myGarage.Park(boat1);
                myGarage.Park(boat2);

                isGarage = true;

                return $"Garage med {myGarage.Capacity} platser är nu skapat. {myGarage.Count()} fordon finns parkerade.";
            }
            catch (Exception)
            {
                return $"Något gick fel. Gick inte att skapa ett garage med {capacity} platser.";
            }
        }


        //public void ListAllVehicles()
        //{
        //    if (isGarage && myGarage.Count() > 0)
        //    {
        //        foreach (Vehicle v in myGarage)
        //            Console.WriteLine(v.ToString());
        //    }
        //    else if (!isGarage)
        //        Console.WriteLine("Det går inte att lista fordon eftersom det inte ens finns ett garage.");
        //    else if (myGarage.Count() <= 0)
        //        Console.WriteLine("Garaget är tomt.");
        //}
        public void ListAllVehicles()
        {
            foreach (Vehicle v in myGarage)
                Console.WriteLine(v.ToString());
        }


        public void ParkVehicle(int typeOfvehicle)
        {
            if (typeOfvehicle == 1)
            {
                try
                {
                    SetFields();
                    Console.WriteLine("Ange antal motorer: ");
                    input = Console.ReadLine();
                    numberOfEngines = Int32.Parse(input);
                    Airplane addAirplane = new Airplane(registrationNumber, brand, modelYear, color, numberOfWheels, numberOfEngines);
                    myGarage.Park(addAirplane);
                    Console.WriteLine("Fordonet är nu parkerat.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Något gick fel vid parkering");
                }
            }
            if (typeOfvehicle == 2)
            {
                try
                {
                    SetFields();
                    Console.WriteLine("Ange cylindervolym: ");
                    input = Console.ReadLine();
                    cylinderVolume = Int32.Parse(input);
                    Motorcycle addMotorcycle = new Motorcycle(registrationNumber, brand, modelYear, color, numberOfWheels, cylinderVolume);
                    myGarage.Park(addMotorcycle);
                    Console.WriteLine("Fordonet är nu parkerat.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Något gick fel vid parkering");
                }
            }
            if (typeOfvehicle == 3)
            {
                try
                {
                    SetFields();
                    Console.WriteLine("Ange bränsletyp: ");
                    fueltype = Console.ReadLine();
                    Car addCar = new Car(registrationNumber, brand, modelYear, color, numberOfWheels, fueltype);
                    myGarage.Park(addCar);
                    Console.WriteLine("Fordonet är nu parkerat.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Något gick fel vid parkering");
                }
            }
            if (typeOfvehicle == 4)
            {
                try
                {
                    SetFields();
                    Console.WriteLine("Ange antal säten: ");
                    input = Console.ReadLine();
                    numberOfSeats = Int32.Parse(input);
                    Bus addBus = new Bus(registrationNumber, brand, modelYear, color, numberOfWheels, numberOfSeats);
                    myGarage.Park(addBus);
                    Console.WriteLine("Fordonet är nu parkerat.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Något gick fel vid parkering");
                }
            }
            if (typeOfvehicle == 5)
            {
                try
                {
                    SetFields();
                    Console.WriteLine("Ange längd: ");
                    input = Console.ReadLine();
                    lenght = Int32.Parse(input);
                    Boat addBoat = new Boat(registrationNumber, brand, modelYear, color, numberOfWheels, lenght);
                    myGarage.Park(addBoat);
                    Console.WriteLine("Fordonet är nu parkerat.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Något gick fel vid parkering");
                }
            }
        }

        //public void SetFields()
        //{
        //    Console.WriteLine("Ange regnr: ");
        //    registrationNumber = Console.ReadLine().ToLower();
        //    bool exist = CheckRegNumber(registrationNumber);
        //    if (exist)
        //    {
        //        Console.WriteLine("Regnr finns redan, välj annat.");
        //        SetFields();
        //    }
        //    Console.WriteLine("Ange märke: ");
        //    brand = Console.ReadLine();
        //    Console.WriteLine("Ange årsmodell: ");
        //    input = Console.ReadLine();
        //    modelYear = Int32.Parse(input);
        //    Console.WriteLine("Ange färg: ");
        //    color = Console.ReadLine();
        //    Console.WriteLine("Ange antal hjul: ");
        //    input = Console.ReadLine();
        //    numberOfWheels = Int32.Parse(input);
        //}
        public void SetFields()
        {
            Console.WriteLine("Ange regnr: ");
            registrationNumber = Console.ReadLine().ToLower();
            bool exist = CheckRegNumber(registrationNumber);
            if (exist)
            {
                Console.WriteLine("Regnr finns redan, välj annat.");
                SetFields();
            }
            Console.WriteLine("Ange märke: ");
            brand = Console.ReadLine().ToLower();
            modelYear = CheckYear();
            Console.WriteLine("Ange färg: ");
            color = Console.ReadLine().ToLower();
            Console.WriteLine("Ange antal hjul: ");
            numberOfWheels = CheckThatInputIsANumber();
        }

        private int CheckYear()
        {
            while (true)
            {
                Console.WriteLine("Ange årsmodell: ");
                input = Console.ReadLine();
                try
                {
                    if (input.Length == 4)
                    {
                        modelYear = Int32.Parse(input);
                        return modelYear;
                    }
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Felaktig inmatning. Försök igen (4 siffror).");
                }
            }
        }

        private int CheckThatInputIsANumber()
        {
            while (true)
            {
                int number;
                input = Console.ReadLine();
                try
                {
                    number = Int32.Parse(input);
                    return number;
                }
                catch (Exception)
                {
                    Console.WriteLine("Felaktig inmatning. Det ska bara vara siffror.");
                }
            }
        }


        public bool CheckRegNumber(string registrationNumber)
        {
            Vehicle? exist = myGarage.FirstOrDefault(v => v.RegistrationNumber == registrationNumber);
            if (exist != null)
                return true;
            return false;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicle? found = myGarage.FirstOrDefault(v => v.RegistrationNumber == vehicle.RegistrationNumber);
            if (found != null)
            {
                myGarage.Park(vehicle);
            }
        }

        //public void RemoveVehicle(string regNo)
        //{
        //    Vehicle? found = myGarage.FirstOrDefault(v => v.RegistrationNumber == regNo);
        //    if (found != null)
        //    {
        //        myGarage.UnPark(found);
        //    }
        //}
        public string RemoveVehicle(string regNo)
        {
            Vehicle? found = myGarage.FirstOrDefault(v => v.RegistrationNumber == regNo);
            if (found != null)
            {
                myGarage.UnPark(found);
                return $"Fordonet med registreringsnummer {regNo} är nu borttaget.";
            }
            else
                return $"Fordonet med registreringsnummer {regNo} fanns inte i garaget.";
        }

        public void ListVehicleTypes()
        {
            if (isGarage && myGarage.Count() > 0)
            {
                var grouped = myGarage.GroupBy(n => n.GetType())
                                 .Select(group => new
                                 {
                                     Value = group.Key.Name,
                                     Count = group.Count()
                                 });

                var sorted = grouped.OrderByDescending(g => g.Count);

                foreach (var group in sorted)
                {
                    Console.WriteLine($"{group.Value}, {group.Count}st");
                }
            }
            else if (!isGarage)
                Console.WriteLine("Det finns inte ens ett garage.");
            else if (myGarage.Count() <= 0)
                Console.WriteLine("Garaget är tomt.");
        }

        public void Search()
        {
            if (isGarage && myGarage.Count() > 0)
            {
                try
                {
                    Console.Write("Välj fordonstyp\n(1.Flygplan  2.Motorcykel  3.Bil  4.Buss  5.Båt  x.Ingen specifik fordonstyp)\nVal: ");
                    type = Console.ReadLine();
                    if(!(type == "1" || type == "2" || type == "3" || type == "4" || type == "5" || type == "x"))
                        Search();
                    Console.Write("Ange märke (skriv x om inget): ");
                    brand = Console.ReadLine().ToLower();
                    Console.Write("Ange årsmodell, 4 siffror (skriv x om inget): ");
                    input = Console.ReadLine();
                    if (input != "x")
                    {
                        try
                        {
                            modelYear = Int32.Parse(input);
                        }
                        catch { }
                    }
                    else if (input == "x")
                        modelYear = -1;
                    Console.Write("Ange färg (skriv x om inget): ");
                    color = Console.ReadLine().ToLower();
                    Console.Write("Ange antal hjul (skriv x om inget): ");
                    input = Console.ReadLine();
                    if (input != "x")
                    {
                        try
                        {
                            numberOfWheels = Int32.Parse(input);
                        }
                        catch
                        {
                            numberOfWheels = -1;
                        }
                    }
                    else if (input == "x")
                        numberOfWheels = -1;

                    PrintVehicles(type, brand, modelYear, color, numberOfWheels);
                }
                catch (Exception)
                {
                    Console.WriteLine("Något gick fel vid sökningen.");
                }
            }
            else if (!isGarage)
                Console.WriteLine("Det finns inte ens ett garage.");
            else if (!myGarage.Any())
                Console.WriteLine("Garaget är tomt. Finns inga fordon att söka.");
        }


        public void PrintVehicles(string type, string brand, int modelYear, string color, int numberOfWheels)
        {
            Vehicle[] foundVehicles = Array.Empty<Vehicle>();
            bool printHeading = true;

            if (type != "x")
            {
                if (type == "1")
                    foundVehicles = myGarage.Where(v => v.GetType().Name == "Airplane").ToArray();
                if (type == "2")
                    foundVehicles = myGarage.Where(v => v.GetType().Name == "Motorcycle").ToArray();
                if (type == "3")
                    foundVehicles = myGarage.Where(v => v.GetType().Name == "Car").ToArray();
                if (type == "4")
                    foundVehicles = myGarage.Where(v => v.GetType().Name == "Bus").ToArray();
                if (type == "5")
                    foundVehicles = myGarage.Where(v => v.GetType().Name == "Boat").ToArray();
            }
            else
                foundVehicles = myGarage.ToArray();
            if (brand != "x")
            {
                foundVehicles = foundVehicles.Where(v => v.Brand == brand).ToArray();
            }
            if (modelYear != -1)
            {
                foundVehicles = foundVehicles.Where(v => v.ModelYear == modelYear).ToArray();
            }
            if (color != "x")
            {
                foundVehicles = foundVehicles.Where(v => v.Color == color).ToArray();
            }
            if (numberOfWheels != -1)
            {
                foundVehicles = foundVehicles.Where(v => v.NumberOfWheels == numberOfWheels).ToArray();
            }

            if (foundVehicles.Length == 0)
            {
                Console.WriteLine("\nDet fanns inga fordon som passade sökkriterierna.");
                return;
            }

            foreach (var vehicle in foundVehicles)
            {
                if (vehicle != null)
                {
                    if (printHeading)
                    {
                        Console.WriteLine("\nResultat av sökningen:");
                        printHeading = false;
                    }
                    Console.WriteLine($"{vehicle.RegistrationNumber}, {vehicle.GetType().Name}, {vehicle.Brand}, {vehicle.ModelYear}, {vehicle.Color}, {vehicle.NumberOfWheels} hjul");
                }
            }
        }


        //public string AvailableParkingSpaces()
        //{
        //    try
        //    {
        //        if (isGarage)
        //        {
        //            int available = myGarage.Capacity - myGarage.Count();
        //            if (available <= 0)
        //                return "Parkeringen är full.";

        //            return $"Det finns {available} platser lediga.";
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return $"Det finns inga lediga platser eftersom det inte finns ett garage.";
        //    }
        //    return $"Det finns inga lediga platser eftersom det inte finns ett garage.";
        //}

        public int AvailableParkingSpaces()
        {
            try
            {
                if (isGarage)
                {
                    int available = myGarage.Capacity - myGarage.Count();
                    if (available == 0)
                        return 0;
                    return available;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            return -1;
        }
    }
}
