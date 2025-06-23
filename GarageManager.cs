namespace Ovning5_Garage1._0
{
    public class GarageManager
    {
        private IGarageUI? garageUI;
        private IGarageHandler? garageHandler;
        private int inputInt;
        private string? feedback;

        public void Run()
        {
            garageUI = new GarageUI();
            garageHandler = new GarageHandler();

            while (true)
            {
                garageUI.PrintMainMeny();

                string? inputString;
                try
                {
                    inputString = Console.ReadLine();
                    inputInt = Int32.Parse(inputString);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ange ett giltigt alternativ!");
                    continue;
                }

                switch (inputInt)
                {
                    case 1:
                        //garageHandler.CreateGarage();

                        Console.Write("Välj storlek på garaget: ");
                        string? input = Console.ReadLine();
                        feedback = garageHandler.CreateGarage(input);
                        Console.WriteLine(feedback);
                        break;
                    case 2:
                        //garageHandler.SeedData();

                        feedback = garageHandler.SeedData(20);
                        Console.WriteLine(feedback);
                        break;
                    case 3:
                        if (garageHandler.IsGarage && garageHandler.NumberOfVehicles > 0)
                            garageHandler.ListAllVehicles();
                        else if (!garageHandler.IsGarage)
                            Console.WriteLine("Kan inte lista fordon. Det finns inte ett garage.");
                        else if (garageHandler.NumberOfVehicles < 1)
                            Console.WriteLine("Garaget är tomt.");
                        break;
                    case 4:
                        if (garageHandler.IsGarage && garageHandler.AvailableParkingSpaces() > 0)
                        {
                            while(true)
                            {
                                garageUI.PrintAddVehicleMeny();
                                input = Console.ReadLine();
                                int typeOfvehicle;
                                try
                                {
                                    typeOfvehicle = Int32.Parse(input);
                                    if (typeOfvehicle > 0 && typeOfvehicle < 6)
                                    {
                                        garageHandler.ParkVehicle(typeOfvehicle);
                                        break;
                                    }
                                    else if (typeOfvehicle == 0)
                                        break;
                                    else if (typeOfvehicle < 0 || typeOfvehicle > 5)
                                        throw new Exception();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Ogiltig inmatning.");
                                }
                            }
                        }
                        else if (!garageHandler.IsGarage)
                            Console.WriteLine("Går inte parkera fordon. Det finns inget garage.");
                        else if (garageHandler.AvailableParkingSpaces() == 0)
                            Console.WriteLine("Parkeringen är full. Går inte att parkera.");
                        break;
                    case 5:
                        if (garageHandler.IsGarage && garageHandler.NumberOfVehicles > 0)
                        {
                            Console.WriteLine("Ange regnummer: ");
                            inputString = Console.ReadLine().ToLower();
                            Console.WriteLine(garageHandler.RemoveVehicle(inputString));
                        }
                        else if (!garageHandler.IsGarage)
                            Console.WriteLine("Kan inte ta bort fordon. Det finns inte ett garage.");
                        else if (garageHandler.NumberOfVehicles < 1)
                            Console.WriteLine("Garaget är redan tomt.");
                        break;
                    case 6:
                        if (garageHandler.IsGarage && garageHandler.NumberOfVehicles > 0)
                            garageHandler.ListVehicleTypes();
                        else if (!garageHandler.IsGarage)
                            Console.WriteLine("Kan inte lista typer av fordon. Det finns inte ens ett garage.");
                        else if (garageHandler.NumberOfVehicles < 1)
                            Console.WriteLine("Garaget är tomt.");
                        break;
                    case 7:
                        if (garageHandler.IsGarage && garageHandler.NumberOfVehicles > 0)
                            garageHandler.Search();
                        else if (!garageHandler.IsGarage)
                            Console.WriteLine("Kan inte söka fordon. Det finns inte ens ett garage.");
                        else if (garageHandler.NumberOfVehicles < 1)
                            Console.WriteLine("Garaget är tomt.");
                        break;
                    case 8:
                        int freeSpaces = garageHandler.AvailableParkingSpaces();
                        if (freeSpaces == -1)
                            Console.WriteLine("Det finns inga lediga platser eftersom det inte finns ett garage.");
                        else if (freeSpaces == 0)
                            Console.WriteLine("Parkeringen är full.");
                        else
                            Console.WriteLine($"Det finns {freeSpaces} platser lediga.");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ange ett giltigt alternativ!");
                        break;
                }
            }
        }
    }
}
