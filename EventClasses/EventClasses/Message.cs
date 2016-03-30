using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    class Message
    {
        public int MessageID { get; private set; }

        public string Content { get; private set; }

        public DateTime TimeStamp { get; private set; }

        public User UserMessage { get; private set; }

        public string Tags { get; private set; }

        public Message ParentMessage { get; private set; }

        private int mcounter = 1; 


        public Message(string mContent, User mUser, string mTags, Message mParent = null)
        {
            MessageID = mcounter;
            mcounter++;
            Content = mContent;
            UserMessage = mUser;
            Tags = mTags;
            if (mParent != null)
            {
                ParentMessage = mParent;
            }
            TimeStamp = DateTime.Now;
        }

        public List<Message> GetMessages(int Mid)
        {
            //database pull up messages with messageID MID and all messages with that message as parentmessage ID, then add them to the list and return the list.
            return null;
        }

        public bool PostMessage(Message pmessage)
        {
            //format data to put into database, then send data over and insert it into the db and return true or false on failure or success
            //Also add in function to see if message is a new message or a reply, this can be handled in the same function.
            return false;
        }

        public bool DeleteMessage(Message dMessage)
        {
            //Delete the selected message from the database. Return true or false depending on outcome.
            return false;
        }

        public bool UpdateMessage(Message uMessage)
        {
            //Update the message with the updated content, return true or false depeinding on outcome.
            return false;
        }
    }
}
