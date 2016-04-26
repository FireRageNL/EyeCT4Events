using System.Collections.Generic;

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
