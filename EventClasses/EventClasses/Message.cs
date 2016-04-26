using System;

namespace EventClasses
{
    public class Message
    {
        public int MessageID { get; private set; }

        public string Content { get; private set; }

        public DateTime TimeStamp { get; private set; }

        public User UserMessage { get; private set; }

        public string Tags { get; private set; }

        public Message ParentMessage { get; private set; }

        public Message(string mContent, User mUser, int mId, Message mParent = null)
        {
            Content = mContent;
            UserMessage = mUser;
            if (mParent != null)
            {
                ParentMessage = mParent;
            }
            MessageID = mId;
            TimeStamp = DateTime.Now;
        }
        public Message(string mContent, User mUser, string mTags, DateTime timestamp, int sMessageId, Message mParent = null)
        {
            MessageID = sMessageId;
            Content = mContent;
            UserMessage = mUser;
            Tags = mTags;
            if (mParent != null)
            {
                ParentMessage = mParent;
            }
            TimeStamp = timestamp;
        }

        public Message(string mContent, User mUser, int mId)
        {
            MessageID = mId;
            Content = mContent;
            UserMessage = mUser;
        }
    }
}
