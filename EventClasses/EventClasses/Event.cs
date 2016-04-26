namespace EventClasses
{
    public class Event
    {
        public Adress EventAddress { get; private set; }

        public string Name { get; private set; }

        public int EventID { get; private set; }


        public Event(Adress adr, string nme, int id)
        {
            EventAddress = adr;
            Name = nme;
            EventID = id;
        }

        public override string ToString()
        {
            return "ID:   " + EventID + "   Name:   " + Name;
        }
    }
}
