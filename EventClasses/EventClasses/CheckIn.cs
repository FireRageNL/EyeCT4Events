namespace EventClasses
{
    public class CheckIn
    {
        public string Naam { get; private set; }
        public bool Betaald { get; private set; }

        public CheckIn(string naam, bool payment)
        {
            Naam = naam;
            Betaald = payment;
        }
    }
    }
