using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Media : Message
    {
        public string Location { get; private set; }
        public Media(string mContent, User mUser, int mId, string location, Message mParent = null) : base(mContent, mUser,mId,mParent)
        {
            this.Location = location;
        }

        public Media(string mContent, User mUser,int mId, string floc) : base(mContent, mUser,mId)
        {
            this.Location = floc;
        }
    }
}
