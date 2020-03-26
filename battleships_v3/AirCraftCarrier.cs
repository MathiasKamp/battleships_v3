namespace battleships_v3
{

    /// <summary>
    /// aircraftcarrier class that inherits from ship class
    /// </summary>
    public class AirCraftCarrier : Ship
    {
        public AirCraftCarrier()
        {
            Name = "Aircraft Carrier";
            Health = 5;
            Identification = 'A';
        }
    }
}