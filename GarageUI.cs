namespace Ovning5_Garage1._0
{
    public class GarageUI : IGarageUI
    {
        public void PrintMainMeny()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Välj alternativ:"
                + "\n1. Skapa ett nytt garage genom att ange antal platser."
                + "\n2. Skapa ett garage med 20 platser, varav 10 är upptagna."
                + "\n3. Lista alla fordon."
                + "\n4. Parkera fordon."
                + "\n5. Ta bort fordon."
                + "\n6. Lista alla typer av fordon."
                + "\n7. Sök fordon."
                + "\n8. Antal lediga platser."
                + "\n0. Avsluta."
                + "\nVal:");
        }


        public void PrintAddVehicleMeny()
        {
            Console.WriteLine("Vad vill du parkera:"
                + "\n1. Flygplan"
                + "\n2. Motorcykel"
                + "\n3. Bil"
                + "\n4. Buss"
                + "\n5. Båt"
                + "\n0. Åter till huvudmenyn"
                + "\nVal:");
        }
    }
}
