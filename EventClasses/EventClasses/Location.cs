namespace EventClasses
{
    public class Location
    {
        public int LocationId { get; private set; }

        private string Description { get; }

        private int Spaces { get; }

        public Location(string desc, int location, int space)
        {
            Description = desc;
            LocationId = location;
            Spaces = space;
        }

        public override string ToString()
        {
            return Description+" - "+ Spaces+"persoons";
        }
    }
}
