namespace EventClasses
{
    public class Media : Message
    {
        public string Location { get; private set; }

        public Media(string mContent, User mUser,int mId, string mTitle, string floc) : base(mContent, mUser,mId,mTitle)
        {
            Location = floc;
        }
    }
}
