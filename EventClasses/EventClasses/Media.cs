using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    class Media : Message
    {
        public string Location { get; private set; }
        public Media(string mContent, User mUser, string mTags, string location, Message mParent = null) : base(mContent, mUser,mTags,mParent)
        {
            this.Location = location;
        }

        public static void DownloadMedia(Media file)
        {
            string download = file.Location;
            //show download screen with where to store the file
        }

        public static void UploadMedia(Media file)
        {
            string storelocation = file.Location;
            //store file at the location, and put its location into the database
        }

        public static void DeleteMedia(Media file)
        {
            string deletelocation = file.Location;
            //delete file from server, and delete record in the database.
        }
    }
}
