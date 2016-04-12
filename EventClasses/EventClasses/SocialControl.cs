using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class SocialControl
    {
        private DBAdmin db = new DBAdmin();

        public List<string> GetPosts()
        {
            return db.GetPosts();
        }

        public List<Message> GetContents(int postid)
        {
            return db.GetContents(postid);
        }
        public bool PostMessage(Message pmessage)
        {
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

        public void PostReply(string message, Media parent, int userid)
        {
            db.PostReply(message, parent, userid);
        }

        public void NewPost(string message, string url,string type, Login val)
        {
            db.NewPost(message, url, type, val);
        }
    }
}
