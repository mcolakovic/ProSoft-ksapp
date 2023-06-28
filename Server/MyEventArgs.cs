using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class MyEventArgs : EventArgs
    {
        public Info info { get; set; }

        public MyEventArgs(Info info)
        {
            this.info = info;
        }
    }
}
