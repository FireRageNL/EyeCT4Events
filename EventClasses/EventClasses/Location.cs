namespace EventClasses
{
    public class Location
    {
        public int LocationId { get; private set; }

        public string Description { get; private set; }

        public Group UserGroup { get; private set; }

        public int Eventid { get; private set; }

        public int Spaces { get; private set; }

        public Location(string desc, int evt, int location, int space)
        {
            Description = desc;
            UserGroup = null;
            Eventid = evt;
            LocationId = location;
            Spaces = space;
        }

        public override string ToString()
        {
            return Description+" - "+ Spaces+"persoons";
        }
    }
}
