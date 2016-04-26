namespace EventClasses
{
    public class RFID
    {
        public User Usr { get; set; }

        public string RfidTag { get; private set; }

        public decimal Funds { get; private set; }


        public void UpdateFunds(decimal update)
        {
            Funds += update;
        }
        
    }
}
