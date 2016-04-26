namespace EventClasses
{
    public class Event
    {
        private string Name { get; }

        private int EventId { get; }


        public Event(string nme, int id)
        {
            Name = nme;
            EventId = id;
        }

        public override string ToString()
        {
            return "ID:   " + EventId + "   Name:   " + Name;
        }
    }
}
