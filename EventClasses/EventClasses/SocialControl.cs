using System.Collections.Generic;

namespace EventClasses
{
    public class SocialControl
    {
        private readonly DbAdmin _db = new DbAdmin();

        public List<string> GetPosts()
        {
            return _db.GetPosts();
        }

        public List<Message> GetContents(int postid)
        {
            return _db.GetContents(postid);
        }

        public void PostReply(string message, Media parent, int userid)
        {
            _db.PostReply(message, parent, userid);
        }

        public void NewPost(string message, string url,string type, Login val)
        {
            _db.NewPost(message, url, type, val);
        }
    }
}
