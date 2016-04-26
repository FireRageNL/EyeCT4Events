namespace EventClasses
{
    public class Message
    {
        public int MessageId { get; private set; }

        public string Content { get; private set; }

        public User UserMessage { get; private set; }

        public Message ParentMessage { get; private set; }

        public Message(string mContent, User mUser, int mId, Message mParent = null)
        {
            Content = mContent;
            UserMessage = mUser;
            if (mParent != null)
            {
                ParentMessage = mParent;
            }
            MessageId = mId;
        }

        protected Message(string mContent, User mUser, int mId)
        {
            MessageId = mId;
            Content = mContent;
            UserMessage = mUser;
        }
    }
}
